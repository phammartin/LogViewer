using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks.Dataflow;
using LogViewer.Helpers;

namespace LogViewer.Parsing
{
    /// <summary>
    /// Processes all log files in a directory and its sub-directories by grouping their contents by timestamp.
    /// </summary>
    class ParseTask
    {
        public ParseTask(string rootFolderpath)
        {
            Id = Guid.NewGuid().ToString();
            RootFolderpath = rootFolderpath;
            FileSet = GetNewFileSet(rootFolderpath);
            TotalFileCount = FileSet.Count;
            State = LogManagement.TaskStates.Pending;
        }

        public void Start(DateTime targetDate)
        {
            State = LogManagement.TaskStates.Started;
            TargetDate = targetDate;
            Task.Run(() => RunTask(FileSet.Values.ToArray()));
        }

        private void RunTask(FileStringUnit[] fileSet)
        {
            // Set the method that will parse logs as they are read from disk.
            var logParser = new ActionBlock<FileStringUnit>(
                new Action<FileStringUnit>(ParseFileContent),
                new ExecutionDataflowBlockOptions
                {
                    MaxDegreeOfParallelism = Environment.ProcessorCount,
                    SingleProducerConstrained = true
                });

            // Read log file and funnel its contents to the parsing method.
            try
            {
                var sw = new System.Diagnostics.Stopwatch();
                sw.Start();

                foreach (var file in fileSet)
                {
                    file.Content = FileUtil.ReadFiletoString(file.Filepath);
                    logParser.Post(file);
                }
                logParser.Complete();
                logParser.Completion.Wait();

                sw.Stop();
                Console.WriteLine($"Total Processing Time: {sw.Elapsed.TotalSeconds} seconds.");

                State = LogManagement.TaskStates.Completed;
                OnLogProcessed(Id, string.Empty, 100, State);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ParseFileContent(FileStringUnit fileContent)
        {
            var targetDate = TargetDate;
            var result = new ParseResultUnit(fileContent.Filepath);
            using (StringReader sr = new StringReader(fileContent.Content))
            {
                int lineNumber = 0;
                while (sr.Peek() != -1)
                {
                    lineNumber++;

                    var line = sr.ReadLine().Trim();
                    var match = TimestampCaptureRegex.Match(line);
                    if (!match.Success)
                    {
                        continue;
                    }
                    DateTime parsedDate;
                    if (!DateTime.TryParse(match.Value, out parsedDate) || targetDate.Date != parsedDate.Date)
                    {
                        continue;
                    }

                    var messageValue = line.Remove(0, match.Value.Length);
                    var messageKey = OnMessageKeyRequested(messageValue);
                    result.AddLine(parsedDate, lineNumber, messageKey);
                }
            }
            fileContent.Clear();
            if (result.Lines.Count == 0)
            {
                FileSet.Remove(fileContent.Filepath);
            }
            AddResult(result);
        }

        private void AddResult(ParseResultUnit result)
        {
            lock (ResultsLock)
            {
                Results.Add(result.Filepath, result);
                ProcessedFileCount++;

                var percentage = GetPercentage(ProcessedFileCount, TotalFileCount);
                var timestamps = result.Lines.Keys;
                OnLogProcessed(Id, result.Filepath, percentage, State, timestamps.ToArray());
            }
        }

        private SortedList<string, FileStringUnit> GetNewFileSet(string rootFolderpath)
        {
            var fileSet = new SortedList<string, FileStringUnit>();
            var fileInfo = FileUtil.GetNestedFileInfo(rootFolderpath);
            foreach (var file in fileInfo)
            {
                fileSet.Add(file.FullName, new FileStringUnit(file.FullName, String.Empty));
            }
            return fileSet;
        }

        private int GetPercentage(int processedCount, int fileCount)
        {
            var percentage = 0;
            if (fileCount != 0 && processedCount != 0)
            {
                percentage = (int)Math.Floor((((double)(processedCount) / fileCount) * 100));
            }
            return percentage;
        }

        #region Published Events
        /// <summary>
        /// When raised, signals that a file has been parsed and provides information for displaying progress.
        /// </summary>
        public static event EventHandler<LogManagement.ProgressUpdateEventArgs> LogProcessed;
        private void OnLogProcessed(string id, string filepath,
            int percentage, LogManagement.TaskStates state, DateTime[] timestamps = null)
        {
            var e = new LogManagement.ProgressUpdateEventArgs(id, filepath, percentage, state, timestamps);
            LogProcessed.Invoke(this, e);
        }

        /// <summary>
        /// When raised, requests a number that can be used later to retrieve a known log message.
        /// </summary>
        public static event MessageKeyRequestedEventHandler MessageKeyRequested;
        public delegate int MessageKeyRequestedEventHandler(string message);
        private int OnMessageKeyRequested(string message)
        {
            return MessageKeyRequested.Invoke(message);
        }
        #endregion

        #region Members
        private readonly SortedList<string, FileStringUnit> FileSet;

        /// <summary>
        /// 
        /// </summary>
        private readonly Regex TimestampCaptureRegex = new Regex(TIMESTAMP_CAPTURE_PATTERN, RegexOptions.Compiled);

        /// <summary>
        /// 
        /// </summary>
        private readonly object ResultsLock = new object();

        /// <summary>
        /// 
        /// </summary>
        private const string TIMESTAMP_CAPTURE_PATTERN = @"\d{1,2}\/\d{1,2}\/\d{4} \d{1,2}\:\d{1,2}\:\d{1,2} [AP][M]";

        /// <summary>
        /// 
        /// </summary>
        private int TotalFileCount;

        /// <summary>
        /// 
        /// </summary>
        private int ProcessedFileCount;

        /// <summary>
        /// 
        /// </summary>
        public LogManagement.TaskStates State;

        /// <summary>
        /// 
        /// </summary>
        public readonly SortedList<string, ParseResultUnit> Results = new SortedList<string, ParseResultUnit>();

        /// <summary>
        /// 
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string RootFolderpath { get; private set; }

        public DateTime TargetDate { get; private set; }
        #endregion
    }
}
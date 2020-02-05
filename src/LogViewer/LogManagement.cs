using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LogViewer.Parsing;
using LogViewer.Helpers;

namespace LogViewer
{
    class LogManagement
    {
        public LogManagement()
        {
            SubscribetoExternalEvents();
        }

        public string StartNewTask(string rootFolderpath, DateTime targetDate)
        {
            var task = new ParseTask(rootFolderpath);
            ParseTasks.Add(task.Id, task);
            task.Start(targetDate);
            return task.Id;
        }

        #region Published Events
        public static EventHandler<ProgressUpdateEventArgs> ProgressUpdate;
        public class ProgressUpdateEventArgs
        {
            public ProgressUpdateEventArgs(string taskId, string filepath,
                int percentage, TaskStates state, DateTime[] timestamps = null)
            {
                TaskId = taskId;
                Filepath = filepath;
                Percentage = percentage;
                State = state;
                Timestamps = timestamps;
            }
            public string TaskId { get; private set; }
            public string Filepath { get; private set; }
            public int Percentage { get; private set; }
            public TaskStates State { get; private set; }
            public DateTime[] Timestamps { get; private set; }
        }
        #endregion

        #region External Events
        private void SubscribetoExternalEvents()
        {
            ParseTask.LogProcessed += LogParseTask_LogProcessed;
            ParseTask.MessageKeyRequested += LogParseTask_MessageKeyRequested;
            ParseResultForm.TimestampSelected += ParseResultForm_TimestampSelected;
        }

        private void LogParseTask_LogProcessed(object sender, ProgressUpdateEventArgs e)
        {
            var task = (ParseTask)sender;
            if (!(task.State == TaskStates.Completed))
            {
                var parseResult = task.Results[e.Filepath];
                UpdateResultGroups(parseResult.TimestampGroups, parseResult);
            }
            ProgressUpdate.Invoke(sender, new ProgressUpdateEventArgs(task.Id, e.Filepath, e.Percentage, e.State));
        }

        private void UpdateResultGroups(DateTime[] timestamps, ParseResultUnit newResult)
        {
            lock (GroupedResultsLock)
            {
                foreach (var timestamp in timestamps)
                {
                    var timestampGroup = timestamp.AddSeconds(-timestamp.Second);
                    if (!GroupedResults.ContainsKey(timestampGroup))
                    {
                        GroupedResults.Add(timestampGroup, new HashSet<ParseResultUnit>());
                        GroupedResults[timestampGroup].Add(newResult);
                    }
                    else
                    {
                        if (!GroupedResults[timestampGroup].Contains(newResult))
                        {
                            GroupedResults[timestampGroup].Add(newResult);
                        }
                    }
                }
            }
        }

        private int LogParseTask_MessageKeyRequested(string message)
        {
            lock (MessageKeyLock)
            {
                var messageKey = -1;
                if (!MessageKeyLookup.TryGetValue(message, out messageKey))
                {
                    messageKey = MessageKeyLookup.Count;
                    MessageKeyLookup.Add(message, messageKey);
                    MessageLookup.Add(messageKey, message);
                }
                return messageKey;
            }
        }

        public void ParseResultForm_TimestampSelected(ParseResultForm.TimestampSelectedEventArgs e)
        {
            var timestamp = e.Timestamp;
            var results = GroupedResults[timestamp].ToArray();
            var filenames = new HashSet<string>();
            var displayLines = new List<string[]>();
            for (int i = 0; i < results.Length; i++)
            {
                var result = results[i];
                var filename = Path.GetFileName(result.Filepath);
                if (filenames.Contains(filename))
                {
                    continue;
                }
                filenames.Add(filename);

                var parsedLines = result[timestamp];
                displayLines.AddRange(FormatParsedLines(filename, parsedLines));
            }
            e.Filenames = filenames.ToArray();
            e.LineData = displayLines.ToArray();
        }

        private string[][] FormatParsedLines(string filename, ParsedLine[] parsedLines)
        {
            var lineData = new List<string[]>();
            foreach (var parsedLine in parsedLines)
            {
                var row = new string[ParseResultForm.LINE_COLUMN_COUNT];
                var message = MessageLookup[parsedLine.MessageKey];
                row[(int)ParseResultForm.ParsedLineColumns.File] = filename;
                row[(int)ParseResultForm.ParsedLineColumns.Line] = parsedLine.LineNumber.ToString();
                row[(int)ParseResultForm.ParsedLineColumns.Date] = parsedLine.Timestamp.ToString();
                row[(int)ParseResultForm.ParsedLineColumns.Message] = message;
                lineData.Add(row);
            }
            return lineData.ToArray();
        }
        #endregion

        #region Members
        private readonly object GroupedResultsLock = new object();
        private readonly object MessageKeyLock = new object();

        /// <summary>
        /// Returns file paths that are grouped by timestamp.
        /// </summary>
        public readonly Dictionary<DateTime, HashSet<ParseResultUnit>> GroupedResults = new Dictionary<DateTime, HashSet<ParseResultUnit>>();

        /// <summary>
        /// Provides access to any log parsing task that has been initiated by the user.
        /// </summary>
        private readonly SortedList<string, ParseTask> ParseTasks = new SortedList<string, ParseTask>();

        /// <summary>
        /// Returns a numeric key associated to a given message string to reduce memory consumption.
        /// </summary>
        private readonly Dictionary<string, int> MessageKeyLookup = new Dictionary<string, int>();

        /// <summary>
        /// Returns a message string associated to a given numeric key for display purposes.
        /// </summary>
        private readonly Dictionary<int, string> MessageLookup = new Dictionary<int, string>();

        public enum TaskStates
        {
            Error = -1,
            Pending = 0,
            Started = 1,
            Completed = 2,
        }
        #endregion
    }
}
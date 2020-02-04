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
        }

        private void LogParseTask_LogProcessed(object sender, ProgressUpdateEventArgs e)
        {
            var task = (ParseTask)sender;
            if (!(task.State == TaskStates.Completed))
            {
                var parseResult = task.Results[e.Filepath];
                UpdateResultGroups(parseResult.Timestamps, parseResult);
            }
            ProgressUpdate.Invoke(sender, new ProgressUpdateEventArgs(task.Id, e.Filepath, e.Percentage, e.State));
        }

        private void UpdateResultGroups(DateTime[] timestamps, ParseResultUnit newResult)
        {
            lock (GroupedResultsLock)
            {
                foreach (var timestamp in timestamps)
                {
                    if (!GroupedResults.ContainsKey(timestamp))
                    {
                        GroupedResults.Add(timestamp, new HashSet<ParseResultUnit>());
                        GroupedResults[timestamp].Add(newResult);
                    }
                    else
                    {
                        if (!GroupedResults[timestamp].Contains(newResult))
                        {
                            GroupedResults[timestamp].Add(newResult);
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
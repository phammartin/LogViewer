using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogViewer.Parsing
{
    class ParseResultUnit
    {
        public ParseResultUnit(string filepath)
        {
            Filepath = filepath;
            Lines = new SortedList<DateTime, List<ParsedLine>>();
        }

        public void AddLine(DateTime timestamp, int lineNumber, int messageId)
        {
            var timestampGroup = new DateTime(timestamp.AddSeconds(-(timestamp.Second)).Ticks);
            if (Lines.ContainsKey(timestampGroup))
            {
                Lines[timestampGroup].Add(new ParsedLine(lineNumber, messageId, timestamp));
            }
            else
            {
                Lines[timestampGroup] = new List<ParsedLine>();
                Lines[timestampGroup].Add(new ParsedLine(lineNumber, messageId, timestamp));
            }
        }
        private SortedList<DateTime, List<ParsedLine>> Lines { get; }

        public ParsedLine[] this[DateTime timestampGroup] => Lines[timestampGroup].ToArray();
        public int Count => Lines.Count;
        public string Filepath { get; private set; }
        public DateTime[] TimestampGroups => Lines.Keys.ToArray();
    }

    class ParsedLine
    {
        public ParsedLine(int lineNumber, int lineTextId, DateTime timestamp)
        {
            LineNumber = lineNumber;
            MessageKey = lineTextId;
            Timestamp = timestamp;
        }

        public int LineNumber { get; private set; }
        public int MessageKey { get; private set; }
        public DateTime Timestamp { get; }
    }
}
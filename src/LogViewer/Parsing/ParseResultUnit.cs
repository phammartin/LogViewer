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
            if (Lines.ContainsKey(timestamp))
            {
                Lines[timestamp].Add(new ParsedLine(lineNumber, messageId));
            }
            else
            {
                Lines[timestamp] = new List<ParsedLine>();
                Lines[timestamp].Add(new ParsedLine(lineNumber, messageId));
            }
        }

        public string Filepath { get; private set; }
        public SortedList<DateTime, List<ParsedLine>> Lines { get; private set; }
        public DateTime[] Timestamps => Lines.Keys.ToArray();
    }

    class ParsedLine
    {
        public ParsedLine(int lineNumber, int lineTextId)
        {
            LineNumber = lineNumber;
            TextId = lineTextId;
        }

        public int LineNumber { get; private set; }
        public int TextId { get; private set; }
    }
}
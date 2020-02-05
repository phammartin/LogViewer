using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogViewer.Parsing;
using LogViewer.Controls;

namespace LogViewer
{
    public partial class ParseResultForm : Form
    {
        public ParseResultForm(DateTime[] timestamps)
        {
            InitializeComponent();
            Timestamps = timestamps;
        }

        private void SetupControls(DateTime[] timestamps)
        {
            lvwTimestamps = ListViewManagement.GenerateCustomListView(splResultSelection.Panel1, new string[] { TIMESTAMPS_COLUMN_HEADER });
            LvwTimestampsManager = new ListViewManagement(lvwTimestamps);
            lvwTimestamps.SelectedIndexChanged += lvwTimestamps_SelectedIndexChanged;

            var timestampText = new string[timestamps.Length][];
            for (int i = 0; i < timestamps.Length; i++)
            {
                timestampText[i] = new string[] { timestamps[i].ToString() };
            }

            LvwTimestampsManager.RefreshRows(timestampText);
            lvwFilenames = ListViewManagement.GenerateCustomListView(splResultSelection.Panel2, new string[] { FILENAMES_COLUMN_HEADER });
            LvwFilenamesManager = new ListViewManagement(lvwFilenames);
            lvwFilenames.SelectedIndexChanged += lvwFilenames_SelectedIndexChanged;

            lvwParsedLines = ListViewManagement.GenerateCustomListView(tpSelectedFile, new string[] { ParsedLineColumns.File.ToString(),
                ParsedLineColumns.Line.ToString(), ParsedLineColumns.Date.ToString(), ParsedLineColumns.Message.ToString() },gridLines: true);
            LvwParsedLinesManager = new ListViewManagement(lvwParsedLines);
        }

        #region UI Events
        private void lvwTimestamps_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lvwItems = lvwTimestamps.SelectedItems;
            if (lvwItems.Count != 1)
            {
                return;
            }
            HandleTimestampSelection(DateTime.Parse(lvwItems[0].Text));
        }
        private void HandleTimestampSelection(DateTime timestamp)
        {
            var e = new TimestampSelectedEventArgs(timestamp);
            TimestampSelected(e);
            var filenames = new string[e.Filenames.Length][];
            for (int i = 0; i < e.Filenames.Length; i++)
            {
                filenames[i] = new string[] { e.Filenames[i] };
            }
            LvwFilenamesManager.RefreshRows(filenames);
            LvwParsedLinesManager.RefreshRows(e.LineData);
        }

        private void lvwFilenames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Published Events
        public static event TimestampSelectedEventHandler TimestampSelected;
        public delegate void TimestampSelectedEventHandler(TimestampSelectedEventArgs e);
        public class TimestampSelectedEventArgs : EventArgs
        {
            public TimestampSelectedEventArgs(DateTime timestamp)
            {
                Timestamp = timestamp;
            }
            public DateTime Timestamp { get; }
            public string[] Filenames { get; set; }
            public string[][] LineData { get; set; }
        }
        #endregion

        #region Members

        private ListViewManagement LvwTimestampsManager;
        private ListViewManagement LvwFilenamesManager;
        private ListViewManagement LvwParsedLinesManager;

        private DateTime[] Timestamps;

        private CustomListView lvwTimestamps;
        private CustomListView lvwFilenames;
        private CustomListView lvwParsedLines;

        private const string TIMESTAMPS_COLUMN_HEADER = "Timestamp Groups";
        private const string FILENAMES_COLUMN_HEADER = "Filenames";
        private const string LINE_COLUMN_HEADER = "Line";
        private const string DATE_COLUMN_HEADER = "Date";
        private const string MESSAGE_COLUMN_HEADER = "Log Message";

        public const int LINE_COLUMN_COUNT = 4;

        public enum ParsedLineColumns
        { File, Line, Date, Message }

        #endregion

        private void ParseResultForm_Shown(object sender, EventArgs e)
        {
            SetupControls(Timestamps);
        }
    }
}

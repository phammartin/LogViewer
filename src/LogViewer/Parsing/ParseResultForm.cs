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
            SetupControls(timestamps);
        }

        private void SetupControls(DateTime[] timestamps)
        {
            lvwControl = ListViewManagement.GenerateCustomListView(splResults.Panel1, new string[] { TIMESTAMP_COLUMN_HEADER });
            LvwTimestampsManager = new ListViewManagement(lvwControl);
            foreach (var timestamp in timestamps)
            {
                var value = timestamp.ToString();
                LvwTimestampsManager.AddNewRow(value, value, new string[] { });
            }

            lvwLogfiles = ListViewManagement.GenerateCustomListView(splResults.Panel2, new string[] { FILENAME_COLUMN_HEADER });

        }

        #region Members

        private ListViewManagement LvwTimestampsManager;
        private ListViewManagement LvwLogFilesManager;

        private CustomListView lvwControl;
        private CustomListView lvwLogfiles;

        private DateTime[] Timestamps;

        private const string TIMESTAMP_COLUMN_HEADER = "Timestamps";
        private const string FILENAME_COLUMN_HEADER = "Filenames";
        #endregion
    }
}

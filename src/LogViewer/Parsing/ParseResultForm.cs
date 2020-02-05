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
            lvwControl = ListViewManagement.GenerateCustomListView(splResultSelection.Panel1, new string[] { TIMESTAMP_COLUMN_HEADER });
            LvwTimestampsManager = new ListViewManagement(lvwControl);

            LvwTimestampsManager.RefreshRows(timestamps);
            lvwLogfiles = ListViewManagement.GenerateCustomListView(splResultSelection.Panel2, new string[] { FILENAME_COLUMN_HEADER });
        }

        #region Published Events
        public static event EventHandler TimestampGroupSelected;
        #endregion

        #region Members

        private ListViewManagement LvwTimestampsManager;
        private ListViewManagement LvwLogFilesManager;

        private DateTime[] Timestamps;

        private CustomListView lvwControl;
        private CustomListView lvwLogfiles;

        private const string TIMESTAMP_COLUMN_HEADER = "Timestamp Groups";
        private const string FILENAME_COLUMN_HEADER = "Filenames";
        #endregion

        private void ParseResultForm_Shown(object sender, EventArgs e)
        {
            SetupControls(Timestamps);
        }
    }
}

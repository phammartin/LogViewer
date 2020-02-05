using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogViewer.Parsing;
using LogViewer.Controls;

namespace LogViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetupControls();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtFolderpath.Text = @"C:\Temp\Logs";
            LogManagement.ProgressUpdate += LogManagement_ProgressUpdate;
            LvwManager = new ListViewManagement(lvwResultListing);
        }

        private void SetupControls()
        {
            //
            //  Result list table
            //
            lvwResultListing = ListViewManagement.GenerateCustomListView(grpResultListing, Enum.GetNames(typeof(ListViewColumns)));
            int colPaddingW = 5,
                colFilepathW = 100,
                colStatusW = lvwResultListing.Width - colFilepathW - colPaddingW;
            lvwResultListing.Columns[(int)ListViewColumns.Status].Width = colFilepathW;
            lvwResultListing.Columns[(int)ListViewColumns.Filepath].Width = colStatusW;
            lvwResultListing.DoubleClick += lvwResultListing_DoubleClick;

            //
            //  Target date picker
            //
            dtpTargetDate.Value = new DateTime(2019, 03, 29);
        }

        #region Form Control Events
        // New Log Processing
        private void btnProcess_Click(object sender, EventArgs e)
        {
            HandleProcessClickEvent(e);
        }
        private void HandleProcessClickEvent(EventArgs e)
        {
            try
            {
                var rootFolder = txtFolderpath.Text;
                var taskId = LogManager.StartNewTask(rootFolder, dtpTargetDate.Value);
                LvwManager.AddRow(taskId, $"{LogManagement.TaskStates.Pending} - {0}%", new string[] { rootFolder });
            }
            catch (Exception ex)
            {
                UpdateToolbarStatus($"Folder path is not valid. Details: {ex.Message}", ToolbarMessageTypes.KnownError);
            }
        }

        // Result Access
        private void lvwResultListing_DoubleClick(object sender, EventArgs e)
        {
            var lvw = (CustomListView)sender;
            var taskId = (lvw.SelectedItems.Count == 1) ? lvw.SelectedItems[0].Name : null;

            if (taskId != null)
            {
                var resultForm = new ParseResultForm(LogManager.GroupedResults.Keys.ToArray());
                resultForm.Show();
            }
        }

        // Drag Drop
        private void txtFolder_DragEnter(object sender, DragEventArgs e)
        {
            HandleFolderDragEvent(e, nameof(DragEnter));
        }
        private void txtFolder_DragDrop(object sender, DragEventArgs e)
        {
            HandleFolderDragEvent(e, nameof(DragDrop));
        }
        private void HandleFolderDragEvent(DragEventArgs e, string eventName)
        {
            try
            {
                switch (eventName)
                {
                    case nameof(DragEnter):
                    {
                        var isFileDrop = e.Data.GetDataPresent(DataFormats.FileDrop);
                        if (!isFileDrop)
                        {
                            UpdateToolbarStatus("Only a folder can be dropped into the text box.", ToolbarMessageTypes.KnownError);
                            return;
                        }

                        var folderpath = GetFirstFolderpath(e);
                        var folderInfo = new System.IO.DirectoryInfo(folderpath);
                        if (folderInfo.Exists)
                        {
                            e.Effect = DragDropEffects.Copy;
                        }
                        else
                        {
                            e.Effect = DragDropEffects.None;
                        }
                        break;

                    }
                    case nameof(DragDrop):
                    {
                        var folderpath = GetFirstFolderpath(e);
                        txtFolderpath.Text = folderpath;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                UpdateToolbarStatus(ex.ToString(), ToolbarMessageTypes.UnknownError);
            }
        }
        private string GetFirstFolderpath(DragEventArgs e)
        {
            string[] filepaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            return filepaths[0];
        }

        // Status Bar Notifications
        private void UpdateToolbarStatus(string message, ToolbarMessageTypes messageType)
        {
            var prefix = "";
            switch (messageType)
            {
                case ToolbarMessageTypes.KnownError:
                {
                    prefix += "Error";
                    break;
                }
                case ToolbarMessageTypes.UnknownError:
                {
                    prefix += "Unexpected Error";
                    break;
                }
                default:
                {
                    break;
                }
            }
            tslblStatus.Text = $"{prefix}: {message}";
        }
        #endregion

        #region External Events
        private void LogManagement_ProgressUpdate(object sender, LogManagement.ProgressUpdateEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                try
                {
                    lblCurrentFile.Text = e.Filepath;
                    LvwManager.UpdateRow(e.TaskId, $"{e.State} - {e.Percentage}%");
                }
                catch (Exception ex)
                {
                    UpdateToolbarStatus(ex.Message, ToolbarMessageTypes.UnknownError);
                }
            });
        }
        #endregion

        #region Members
        /// <summary>
        /// The application manager. Performs all log operations requested by the Form.
        /// </summary>
        private readonly LogManagement LogManager = new LogManagement();

        /// <summary>
        /// The results listing manager that populates the control's data while keeping the UI responsive.
        /// </summary>
        private ListViewManagement LvwManager;

        /// <summary>
        /// Control for displaying all logs and their current state.
        /// </summary>
        private CustomListView lvwResultListing;

        private enum ListViewColumns
        {
            Status,
            Filepath
        }
        private enum ToolbarMessageTypes
        {
            CurrentFilename,
            KnownError,
            UnknownError
        }
        #endregion

        private void dtpTargetDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
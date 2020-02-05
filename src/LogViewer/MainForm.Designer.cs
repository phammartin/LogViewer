namespace LogViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBase = new System.Windows.Forms.Panel();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlBaseChild = new System.Windows.Forms.Panel();
            this.grpProcessNewLogs = new System.Windows.Forms.GroupBox();
            this.lblTargetDate = new System.Windows.Forms.Label();
            this.dtpTargetDate = new System.Windows.Forms.DateTimePicker();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.lblLogFolder = new System.Windows.Forms.Label();
            this.txtFolderpath = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.grpResultListing = new System.Windows.Forms.GroupBox();
            this.pnlBase.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.pnlBaseChild.SuspendLayout();
            this.grpProcessNewLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.ssStatus);
            this.pnlBase.Controls.Add(this.pnlBaseChild);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBase.Location = new System.Drawing.Point(0, 0);
            this.pnlBase.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlBase.Size = new System.Drawing.Size(1600, 865);
            this.pnlBase.TabIndex = 2;
            // 
            // ssStatus
            // 
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblStatus});
            this.ssStatus.Location = new System.Drawing.Point(6, 837);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.ssStatus.Size = new System.Drawing.Size(1588, 22);
            this.ssStatus.TabIndex = 1;
            this.ssStatus.Text = "StatusStrip1";
            // 
            // tslblStatus
            // 
            this.tslblStatus.AutoToolTip = true;
            this.tslblStatus.Name = "tslblStatus";
            this.tslblStatus.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tslblStatus.Size = new System.Drawing.Size(0, 12);
            // 
            // pnlBaseChild
            // 
            this.pnlBaseChild.Controls.Add(this.grpProcessNewLogs);
            this.pnlBaseChild.Controls.Add(this.grpResultListing);
            this.pnlBaseChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBaseChild.Location = new System.Drawing.Point(6, 6);
            this.pnlBaseChild.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlBaseChild.Name = "pnlBaseChild";
            this.pnlBaseChild.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pnlBaseChild.Size = new System.Drawing.Size(1588, 853);
            this.pnlBaseChild.TabIndex = 2;
            // 
            // grpProcessNewLogs
            // 
            this.grpProcessNewLogs.Controls.Add(this.lblTargetDate);
            this.grpProcessNewLogs.Controls.Add(this.dtpTargetDate);
            this.grpProcessNewLogs.Controls.Add(this.lblCurrentFile);
            this.grpProcessNewLogs.Controls.Add(this.lblLogFolder);
            this.grpProcessNewLogs.Controls.Add(this.txtFolderpath);
            this.grpProcessNewLogs.Controls.Add(this.btnProcess);
            this.grpProcessNewLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpProcessNewLogs.Location = new System.Drawing.Point(10, 10);
            this.grpProcessNewLogs.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.grpProcessNewLogs.Name = "grpProcessNewLogs";
            this.grpProcessNewLogs.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.grpProcessNewLogs.Size = new System.Drawing.Size(1568, 211);
            this.grpProcessNewLogs.TabIndex = 1;
            this.grpProcessNewLogs.TabStop = false;
            this.grpProcessNewLogs.Text = "Process New Logs";
            // 
            // lblTargetDate
            // 
            this.lblTargetDate.AutoSize = true;
            this.lblTargetDate.Location = new System.Drawing.Point(28, 111);
            this.lblTargetDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTargetDate.Name = "lblTargetDate";
            this.lblTargetDate.Size = new System.Drawing.Size(128, 25);
            this.lblTargetDate.TabIndex = 12;
            this.lblTargetDate.Text = "Target date:";
            // 
            // dtpTargetDate
            // 
            this.dtpTargetDate.CustomFormat = "MM/dd/yyyy";
            this.dtpTargetDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTargetDate.Location = new System.Drawing.Point(168, 106);
            this.dtpTargetDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpTargetDate.Name = "dtpTargetDate";
            this.dtpTargetDate.Size = new System.Drawing.Size(188, 31);
            this.dtpTargetDate.TabIndex = 11;
            this.dtpTargetDate.ValueChanged += new System.EventHandler(this.dtpTargetDate_ValueChanged);
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Location = new System.Drawing.Point(22, 162);
            this.lblCurrentFile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(0, 25);
            this.lblCurrentFile.TabIndex = 9;
            // 
            // lblLogFolder
            // 
            this.lblLogFolder.AutoSize = true;
            this.lblLogFolder.Location = new System.Drawing.Point(42, 58);
            this.lblLogFolder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLogFolder.Name = "lblLogFolder";
            this.lblLogFolder.Size = new System.Drawing.Size(114, 25);
            this.lblLogFolder.TabIndex = 7;
            this.lblLogFolder.Text = "Log folder:";
            // 
            // txtFolderpath
            // 
            this.txtFolderpath.AllowDrop = true;
            this.txtFolderpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderpath.Location = new System.Drawing.Point(168, 52);
            this.txtFolderpath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFolderpath.Name = "txtFolderpath";
            this.txtFolderpath.Size = new System.Drawing.Size(1380, 31);
            this.txtFolderpath.TabIndex = 8;
            this.txtFolderpath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFolder_DragDrop);
            this.txtFolderpath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFolder_DragEnter);
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.Location = new System.Drawing.Point(1442, 102);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(110, 42);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // grpResultListing
            // 
            this.grpResultListing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResultListing.Location = new System.Drawing.Point(10, 241);
            this.grpResultListing.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.grpResultListing.Name = "grpResultListing";
            this.grpResultListing.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.grpResultListing.Size = new System.Drawing.Size(1568, 560);
            this.grpResultListing.TabIndex = 0;
            this.grpResultListing.TabStop = false;
            this.grpResultListing.Text = "Result Listing";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.pnlBase);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Log Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.pnlBaseChild.ResumeLayout(false);
            this.grpProcessNewLogs.ResumeLayout(false);
            this.grpProcessNewLogs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlBase;
        internal System.Windows.Forms.StatusStrip ssStatus;
        internal System.Windows.Forms.ToolStripStatusLabel tslblStatus;
        internal System.Windows.Forms.Panel pnlBaseChild;
        internal System.Windows.Forms.GroupBox grpProcessNewLogs;
        internal System.Windows.Forms.Label lblCurrentFile;
        internal System.Windows.Forms.Label lblLogFolder;
        internal System.Windows.Forms.TextBox txtFolderpath;
        internal System.Windows.Forms.Button btnProcess;
        internal System.Windows.Forms.GroupBox grpResultListing;
        internal System.Windows.Forms.Label lblTargetDate;
        private System.Windows.Forms.DateTimePicker dtpTargetDate;
    }
}
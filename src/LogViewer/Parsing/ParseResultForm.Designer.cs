namespace LogViewer
{
    partial class ParseResultForm
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
            this.splBase = new System.Windows.Forms.SplitContainer();
            this.grpResultSelection = new System.Windows.Forms.GroupBox();
            this.splResultSelection = new System.Windows.Forms.SplitContainer();
            this.tplLogData = new System.Windows.Forms.TableLayoutPanel();
            this.grpOpenedLogFiles = new System.Windows.Forms.GroupBox();
            this.tabOpenedLogFiles = new System.Windows.Forms.TabControl();
            this.tpSelectedLogFile = new System.Windows.Forms.TabPage();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tslblTotalHits = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splBase)).BeginInit();
            this.splBase.Panel1.SuspendLayout();
            this.splBase.Panel2.SuspendLayout();
            this.splBase.SuspendLayout();
            this.grpResultSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splResultSelection)).BeginInit();
            this.splResultSelection.SuspendLayout();
            this.tplLogData.SuspendLayout();
            this.grpOpenedLogFiles.SuspendLayout();
            this.tabOpenedLogFiles.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // splBase
            // 
            this.splBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splBase.IsSplitterFixed = true;
            this.splBase.Location = new System.Drawing.Point(0, 0);
            this.splBase.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.splBase.Name = "splBase";
            // 
            // splBase.Panel1
            // 
            this.splBase.Panel1.Controls.Add(this.grpResultSelection);
            this.splBase.Panel1.Padding = new System.Windows.Forms.Padding(16, 10, 10, 10);
            // 
            // splBase.Panel2
            // 
            this.splBase.Panel2.Controls.Add(this.tplLogData);
            this.splBase.Panel2.Padding = new System.Windows.Forms.Padding(10, 10, 8, 0);
            this.splBase.Size = new System.Drawing.Size(1600, 823);
            this.splBase.SplitterDistance = 340;
            this.splBase.SplitterWidth = 2;
            this.splBase.TabIndex = 7;
            this.splBase.TabStop = false;
            // 
            // grpResultSelection
            // 
            this.grpResultSelection.Controls.Add(this.splResultSelection);
            this.grpResultSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResultSelection.Location = new System.Drawing.Point(16, 10);
            this.grpResultSelection.Margin = new System.Windows.Forms.Padding(200, 10, 10, 10);
            this.grpResultSelection.Name = "grpResultSelection";
            this.grpResultSelection.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.grpResultSelection.Size = new System.Drawing.Size(314, 803);
            this.grpResultSelection.TabIndex = 0;
            this.grpResultSelection.TabStop = false;
            this.grpResultSelection.Text = "Result Selection";
            // 
            // splResultSelection
            // 
            this.splResultSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splResultSelection.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splResultSelection.IsSplitterFixed = true;
            this.splResultSelection.Location = new System.Drawing.Point(10, 34);
            this.splResultSelection.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.splResultSelection.Name = "splResultSelection";
            this.splResultSelection.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splResultSelection.Panel1MinSize = 140;
            this.splResultSelection.Panel2MinSize = 130;
            this.splResultSelection.Size = new System.Drawing.Size(294, 759);
            this.splResultSelection.SplitterDistance = 405;
            this.splResultSelection.TabIndex = 2;
            // 
            // tplLogData
            // 
            this.tplLogData.ColumnCount = 1;
            this.tplLogData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplLogData.Controls.Add(this.grpOpenedLogFiles, 0, 0);
            this.tplLogData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplLogData.Location = new System.Drawing.Point(10, 10);
            this.tplLogData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tplLogData.Name = "tplLogData";
            this.tplLogData.RowCount = 1;
            this.tplLogData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplLogData.Size = new System.Drawing.Size(1240, 813);
            this.tplLogData.TabIndex = 2;
            // 
            // grpOpenedLogFiles
            // 
            this.grpOpenedLogFiles.Controls.Add(this.tabOpenedLogFiles);
            this.grpOpenedLogFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOpenedLogFiles.Location = new System.Drawing.Point(10, 0);
            this.grpOpenedLogFiles.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.grpOpenedLogFiles.Name = "grpOpenedLogFiles";
            this.grpOpenedLogFiles.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.grpOpenedLogFiles.Size = new System.Drawing.Size(1220, 803);
            this.grpOpenedLogFiles.TabIndex = 1;
            this.grpOpenedLogFiles.TabStop = false;
            this.grpOpenedLogFiles.Text = "Opened Log Files";
            // 
            // tabOpenedLogFiles
            // 
            this.tabOpenedLogFiles.Controls.Add(this.tpSelectedLogFile);
            this.tabOpenedLogFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOpenedLogFiles.Location = new System.Drawing.Point(10, 34);
            this.tabOpenedLogFiles.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabOpenedLogFiles.Name = "tabOpenedLogFiles";
            this.tabOpenedLogFiles.SelectedIndex = 0;
            this.tabOpenedLogFiles.Size = new System.Drawing.Size(1200, 759);
            this.tabOpenedLogFiles.TabIndex = 0;
            // 
            // tpSelectedLogFile
            // 
            this.tpSelectedLogFile.Location = new System.Drawing.Point(8, 39);
            this.tpSelectedLogFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpSelectedLogFile.Name = "tpSelectedLogFile";
            this.tpSelectedLogFile.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpSelectedLogFile.Size = new System.Drawing.Size(1184, 712);
            this.tpSelectedLogFile.TabIndex = 0;
            this.tpSelectedLogFile.UseVisualStyleBackColor = true;
            // 
            // ssStatus
            // 
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblTotalHits});
            this.ssStatus.Location = new System.Drawing.Point(0, 823);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.ssStatus.Size = new System.Drawing.Size(1600, 42);
            this.ssStatus.TabIndex = 8;
            this.ssStatus.Text = "StatusStrip1";
            // 
            // tslblTotalHits
            // 
            this.tslblTotalHits.Name = "tslblTotalHits";
            this.tslblTotalHits.Size = new System.Drawing.Size(119, 32);
            this.tslblTotalHits.Text = "Total Hits:";
            // 
            // ParseResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.splBase);
            this.Controls.Add(this.ssStatus);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ParseResultForm";
            this.Text = "Parse Results";
            this.Shown += new System.EventHandler(this.ParseResultForm_Shown);
            this.splBase.Panel1.ResumeLayout(false);
            this.splBase.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splBase)).EndInit();
            this.splBase.ResumeLayout(false);
            this.grpResultSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splResultSelection)).EndInit();
            this.splResultSelection.ResumeLayout(false);
            this.tplLogData.ResumeLayout(false);
            this.grpOpenedLogFiles.ResumeLayout(false);
            this.tabOpenedLogFiles.ResumeLayout(false);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.SplitContainer splBase;
        internal System.Windows.Forms.GroupBox grpResultSelection;
        internal System.Windows.Forms.TableLayoutPanel tplLogData;
        internal System.Windows.Forms.GroupBox grpOpenedLogFiles;
        internal System.Windows.Forms.TabControl tabOpenedLogFiles;
        internal System.Windows.Forms.TabPage tpSelectedLogFile;
        internal System.Windows.Forms.StatusStrip ssStatus;
        internal System.Windows.Forms.ToolStripStatusLabel tslblTotalHits;
        private System.Windows.Forms.SplitContainer splResultSelection;
    }
}


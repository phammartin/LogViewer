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
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.splResults = new System.Windows.Forms.SplitContainer();
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
            this.grpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splResults)).BeginInit();
            this.splResults.SuspendLayout();
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
            this.splBase.Margin = new System.Windows.Forms.Padding(5);
            this.splBase.Name = "splBase";
            // 
            // splBase.Panel1
            // 
            this.splBase.Panel1.Controls.Add(this.grpResults);
            this.splBase.Panel1.Padding = new System.Windows.Forms.Padding(8, 5, 5, 5);
            // 
            // splBase.Panel2
            // 
            this.splBase.Panel2.Controls.Add(this.tplLogData);
            this.splBase.Panel2.Padding = new System.Windows.Forms.Padding(5, 5, 4, 0);
            this.splBase.Size = new System.Drawing.Size(800, 428);
            this.splBase.SplitterDistance = 170;
            this.splBase.SplitterWidth = 1;
            this.splBase.TabIndex = 7;
            this.splBase.TabStop = false;
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.splResults);
            this.grpResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResults.Location = new System.Drawing.Point(8, 5);
            this.grpResults.Margin = new System.Windows.Forms.Padding(100, 5, 5, 5);
            this.grpResults.Name = "grpResults";
            this.grpResults.Padding = new System.Windows.Forms.Padding(5);
            this.grpResults.Size = new System.Drawing.Size(157, 418);
            this.grpResults.TabIndex = 0;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // splResults
            // 
            this.splResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splResults.Location = new System.Drawing.Point(5, 18);
            this.splResults.Name = "splResults";
            this.splResults.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splResults.Size = new System.Drawing.Size(147, 395);
            this.splResults.SplitterDistance = 200;
            this.splResults.TabIndex = 2;
            // 
            // tplLogData
            // 
            this.tplLogData.ColumnCount = 1;
            this.tplLogData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplLogData.Controls.Add(this.grpOpenedLogFiles, 0, 0);
            this.tplLogData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplLogData.Location = new System.Drawing.Point(5, 5);
            this.tplLogData.Name = "tplLogData";
            this.tplLogData.RowCount = 1;
            this.tplLogData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplLogData.Size = new System.Drawing.Size(620, 423);
            this.tplLogData.TabIndex = 2;
            // 
            // grpOpenedLogFiles
            // 
            this.grpOpenedLogFiles.Controls.Add(this.tabOpenedLogFiles);
            this.grpOpenedLogFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOpenedLogFiles.Location = new System.Drawing.Point(5, 0);
            this.grpOpenedLogFiles.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.grpOpenedLogFiles.Name = "grpOpenedLogFiles";
            this.grpOpenedLogFiles.Padding = new System.Windows.Forms.Padding(5);
            this.grpOpenedLogFiles.Size = new System.Drawing.Size(610, 418);
            this.grpOpenedLogFiles.TabIndex = 1;
            this.grpOpenedLogFiles.TabStop = false;
            this.grpOpenedLogFiles.Text = "Opened Log Files";
            // 
            // tabOpenedLogFiles
            // 
            this.tabOpenedLogFiles.Controls.Add(this.tpSelectedLogFile);
            this.tabOpenedLogFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOpenedLogFiles.Location = new System.Drawing.Point(5, 18);
            this.tabOpenedLogFiles.Name = "tabOpenedLogFiles";
            this.tabOpenedLogFiles.SelectedIndex = 0;
            this.tabOpenedLogFiles.Size = new System.Drawing.Size(600, 395);
            this.tabOpenedLogFiles.TabIndex = 0;
            // 
            // tpSelectedLogFile
            // 
            this.tpSelectedLogFile.Location = new System.Drawing.Point(4, 22);
            this.tpSelectedLogFile.Name = "tpSelectedLogFile";
            this.tpSelectedLogFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpSelectedLogFile.Size = new System.Drawing.Size(592, 369);
            this.tpSelectedLogFile.TabIndex = 0;
            this.tpSelectedLogFile.UseVisualStyleBackColor = true;
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblTotalHits});
            this.ssStatus.Location = new System.Drawing.Point(0, 428);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(800, 22);
            this.ssStatus.TabIndex = 8;
            this.ssStatus.Text = "StatusStrip1";
            // 
            // tslblTotalHits
            // 
            this.tslblTotalHits.Name = "tslblTotalHits";
            this.tslblTotalHits.Size = new System.Drawing.Size(59, 17);
            this.tslblTotalHits.Text = "Total Hits:";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splBase);
            this.Controls.Add(this.ssStatus);
            this.DoubleBuffered = true;
            this.Name = "ResultForm";
            this.Text = "Results";
            this.splBase.Panel1.ResumeLayout(false);
            this.splBase.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splBase)).EndInit();
            this.splBase.ResumeLayout(false);
            this.grpResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splResults)).EndInit();
            this.splResults.ResumeLayout(false);
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
        internal System.Windows.Forms.GroupBox grpResults;
        internal System.Windows.Forms.TableLayoutPanel tplLogData;
        internal System.Windows.Forms.GroupBox grpOpenedLogFiles;
        internal System.Windows.Forms.TabControl tabOpenedLogFiles;
        internal System.Windows.Forms.TabPage tpSelectedLogFile;
        internal System.Windows.Forms.StatusStrip ssStatus;
        internal System.Windows.Forms.ToolStripStatusLabel tslblTotalHits;
        private System.Windows.Forms.SplitContainer splResults;
    }
}


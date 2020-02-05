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
            this.grpParsedLines = new System.Windows.Forms.GroupBox();
            this.tabOpenedLogFiles = new System.Windows.Forms.TabControl();
            this.tpSelectedFile = new System.Windows.Forms.TabPage();
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
            this.grpParsedLines.SuspendLayout();
            this.tabOpenedLogFiles.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // splBase
            // 
            this.splBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splBase.Location = new System.Drawing.Point(0, 0);
            this.splBase.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.splBase.Name = "splBase";
            // 
            // splBase.Panel1
            // 
            this.splBase.Panel1.Controls.Add(this.grpResultSelection);
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
            // grpResultSelection
            // 
            this.grpResultSelection.Controls.Add(this.splResultSelection);
            this.grpResultSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResultSelection.Location = new System.Drawing.Point(8, 5);
            this.grpResultSelection.Margin = new System.Windows.Forms.Padding(100, 5, 5, 5);
            this.grpResultSelection.Name = "grpResultSelection";
            this.grpResultSelection.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grpResultSelection.Size = new System.Drawing.Size(157, 418);
            this.grpResultSelection.TabIndex = 0;
            this.grpResultSelection.TabStop = false;
            this.grpResultSelection.Text = "Result Selection";
            // 
            // splResultSelection
            // 
            this.splResultSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splResultSelection.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splResultSelection.IsSplitterFixed = true;
            this.splResultSelection.Location = new System.Drawing.Point(5, 18);
            this.splResultSelection.Name = "splResultSelection";
            this.splResultSelection.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splResultSelection.Panel1MinSize = 140;
            this.splResultSelection.Panel2MinSize = 130;
            this.splResultSelection.Size = new System.Drawing.Size(147, 395);
            this.splResultSelection.SplitterDistance = 140;
            this.splResultSelection.SplitterWidth = 2;
            this.splResultSelection.TabIndex = 2;
            // 
            // tplLogData
            // 
            this.tplLogData.ColumnCount = 1;
            this.tplLogData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplLogData.Controls.Add(this.grpParsedLines, 0, 0);
            this.tplLogData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplLogData.Location = new System.Drawing.Point(5, 5);
            this.tplLogData.Name = "tplLogData";
            this.tplLogData.RowCount = 1;
            this.tplLogData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplLogData.Size = new System.Drawing.Size(620, 423);
            this.tplLogData.TabIndex = 2;
            // 
            // grpParsedLines
            // 
            this.grpParsedLines.Controls.Add(this.tabOpenedLogFiles);
            this.grpParsedLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpParsedLines.Location = new System.Drawing.Point(5, 0);
            this.grpParsedLines.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.grpParsedLines.Name = "grpParsedLines";
            this.grpParsedLines.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grpParsedLines.Size = new System.Drawing.Size(610, 418);
            this.grpParsedLines.TabIndex = 1;
            this.grpParsedLines.TabStop = false;
            this.grpParsedLines.Text = "Parsed Lines";
            // 
            // tabOpenedLogFiles
            // 
            this.tabOpenedLogFiles.Controls.Add(this.tpSelectedFile);
            this.tabOpenedLogFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOpenedLogFiles.Location = new System.Drawing.Point(5, 18);
            this.tabOpenedLogFiles.Name = "tabOpenedLogFiles";
            this.tabOpenedLogFiles.SelectedIndex = 0;
            this.tabOpenedLogFiles.Size = new System.Drawing.Size(600, 395);
            this.tabOpenedLogFiles.TabIndex = 0;
            // 
            // tpSelectedFile
            // 
            this.tpSelectedFile.Location = new System.Drawing.Point(4, 22);
            this.tpSelectedFile.Name = "tpSelectedFile";
            this.tpSelectedFile.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpSelectedFile.Size = new System.Drawing.Size(592, 369);
            this.tpSelectedFile.TabIndex = 0;
            this.tpSelectedFile.Text = "Selected File";
            this.tpSelectedFile.UseVisualStyleBackColor = true;
            // 
            // ssStatus
            // 
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(32, 32);
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
            // ParseResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splBase);
            this.Controls.Add(this.ssStatus);
            this.DoubleBuffered = true;
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
            this.grpParsedLines.ResumeLayout(false);
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
        internal System.Windows.Forms.GroupBox grpParsedLines;
        internal System.Windows.Forms.TabControl tabOpenedLogFiles;
        internal System.Windows.Forms.TabPage tpSelectedFile;
        internal System.Windows.Forms.StatusStrip ssStatus;
        internal System.Windows.Forms.ToolStripStatusLabel tslblTotalHits;
        private System.Windows.Forms.SplitContainer splResultSelection;
    }
}


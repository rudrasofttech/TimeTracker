namespace TimeTracker
{
    partial class ReportForm
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
            this.ReportGridView = new System.Windows.Forms.DataGridView();
            this.ProjectTB = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TotalHoursLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ReportCalendar = new System.Windows.Forms.MonthCalendar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportGridView
            // 
            this.ReportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportGridView.Location = new System.Drawing.Point(0, 0);
            this.ReportGridView.Name = "ReportGridView";
            this.ReportGridView.Size = new System.Drawing.Size(560, 428);
            this.ReportGridView.TabIndex = 0;
            // 
            // ProjectTB
            // 
            this.ProjectTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProjectTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProjectTB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTB.Location = new System.Drawing.Point(6, 182);
            this.ProjectTB.Name = "ProjectTB";
            this.ProjectTB.Size = new System.Drawing.Size(225, 22);
            this.ProjectTB.TabIndex = 7;
            this.ProjectTB.TextChanged += new System.EventHandler(this.ProjectTB_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TotalHoursLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TotalHoursLabel
            // 
            this.TotalHoursLabel.Name = "TotalHoursLabel";
            this.TotalHoursLabel.Size = new System.Drawing.Size(17, 17);
            this.TotalHoursLabel.Text = "--";
            // 
            // ReportCalendar
            // 
            this.ReportCalendar.Location = new System.Drawing.Point(5, 5);
            this.ReportCalendar.MaxSelectionCount = 60;
            this.ReportCalendar.Name = "ReportCalendar";
            this.ReportCalendar.TabIndex = 9;
            this.ReportCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.ReportCalendar_DateChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ReportCalendar);
            this.splitContainer1.Panel1.Controls.Add(this.ProjectTB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ReportGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 428);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 10;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.ShowIcon = false;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportGridView;
        private System.Windows.Forms.TextBox ProjectTB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TotalHoursLabel;
        private System.Windows.Forms.MonthCalendar ReportCalendar;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
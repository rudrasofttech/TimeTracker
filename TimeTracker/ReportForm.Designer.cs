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
            this.ReportDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ProjectTB = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TotalHoursLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportGridView
            // 
            this.ReportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportGridView.Location = new System.Drawing.Point(12, 52);
            this.ReportGridView.Name = "ReportGridView";
            this.ReportGridView.Size = new System.Drawing.Size(776, 364);
            this.ReportGridView.TabIndex = 0;
            // 
            // ReportDatePicker
            // 
            this.ReportDatePicker.Location = new System.Drawing.Point(13, 13);
            this.ReportDatePicker.Name = "ReportDatePicker";
            this.ReportDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ReportDatePicker.TabIndex = 1;
            this.ReportDatePicker.Value = new System.DateTime(2019, 11, 23, 18, 52, 20, 0);
            this.ReportDatePicker.ValueChanged += new System.EventHandler(this.ReportDatePicker_ValueChanged);
            // 
            // ProjectTB
            // 
            this.ProjectTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProjectTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProjectTB.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTB.Location = new System.Drawing.Point(249, 6);
            this.ProjectTB.Name = "ProjectTB";
            this.ProjectTB.Size = new System.Drawing.Size(272, 27);
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
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ProjectTB);
            this.Controls.Add(this.ReportDatePicker);
            this.Controls.Add(this.ReportGridView);
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.ShowIcon = false;
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportGridView;
        private System.Windows.Forms.DateTimePicker ReportDatePicker;
        private System.Windows.Forms.TextBox ProjectTB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TotalHoursLabel;
    }
}
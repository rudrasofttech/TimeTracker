namespace TimeTracker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TimeTrackedLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.TaskTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectTB = new System.Windows.Forms.TextBox();
            this.TrackTimer = new System.Windows.Forms.Timer(this.components);
            this.NotificationTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TodayRptBt = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeTrackedLB
            // 
            this.TimeTrackedLB.AutoSize = true;
            this.TimeTrackedLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTrackedLB.Location = new System.Drawing.Point(117, 148);
            this.TimeTrackedLB.Name = "TimeTrackedLB";
            this.TimeTrackedLB.Size = new System.Drawing.Size(119, 46);
            this.TimeTrackedLB.TabIndex = 0;
            this.TimeTrackedLB.Text = "00:00";
            // 
            // StartBT
            // 
            this.StartBT.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBT.Location = new System.Drawing.Point(15, 212);
            this.StartBT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(144, 61);
            this.StartBT.TabIndex = 1;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBT.Location = new System.Drawing.Point(189, 215);
            this.StopBT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(143, 58);
            this.StopBT.TabIndex = 2;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // TaskTB
            // 
            this.TaskTB.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskTB.Location = new System.Drawing.Point(15, 96);
            this.TaskTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TaskTB.Name = "TaskTB";
            this.TaskTB.Size = new System.Drawing.Size(313, 27);
            this.TaskTB.TabIndex = 3;
            this.TaskTB.TextChanged += new System.EventHandler(this.TaskTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Project";
            // 
            // ProjectTB
            // 
            this.ProjectTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProjectTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProjectTB.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTB.Location = new System.Drawing.Point(15, 34);
            this.ProjectTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ProjectTB.Name = "ProjectTB";
            this.ProjectTB.Size = new System.Drawing.Size(316, 27);
            this.ProjectTB.TabIndex = 6;
            this.ProjectTB.TextChanged += new System.EventHandler(this.ProjectTB_TextChanged);
            // 
            // TrackTimer
            // 
            this.TrackTimer.Interval = 3000;
            this.TrackTimer.Tick += new System.EventHandler(this.TrackTimer_Tick);
            // 
            // NotificationTimer
            // 
            this.NotificationTimer.Interval = 300000;
            this.NotificationTimer.Tick += new System.EventHandler(this.NotificationTimer_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TodayRptBt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 278);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(340, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TodayRptBt
            // 
            this.TodayRptBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TodayRptBt.Image = ((System.Drawing.Image)(resources.GetObject("TodayRptBt.Image")));
            this.TodayRptBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TodayRptBt.Name = "TodayRptBt";
            this.TodayRptBt.Size = new System.Drawing.Size(46, 22);
            this.TodayRptBt.Text = "Report";
            this.TodayRptBt.Click += new System.EventHandler(this.TodayRptBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 303);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ProjectTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaskTB);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.TimeTrackedLB);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Time Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeTrackedLB;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.TextBox TaskTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProjectTB;
        private System.Windows.Forms.Timer TrackTimer;
        private System.Windows.Forms.Timer NotificationTimer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TodayRptBt;
    }
}


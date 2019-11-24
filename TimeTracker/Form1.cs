using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace TimeTracker
{
    public partial class Form1 : Form
    {
        private bool _isTracking = false;
        public bool IsTracking
        {
            get
            {
                return _isTracking;
            }
            set
            {
                _isTracking = value;
                StartBT.Enabled = !_isTracking;
                StopBT.Enabled = _isTracking;
                
                if (!_isTracking)
                {
                    CurrentTD = null;
                    TrackTimer.Stop();
                    
                }
                else
                {
                    TrackTimer.Start();
                    
                }
            }
        }

        public TrackDetail CurrentTD { get; set; }
        public Form1()
        {
            InitializeComponent();
            IsTracking = false;
            CurrentTD = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProjectTB.AutoCompleteCustomSource = GetProjectList();
            NotificationTimer.Start();
        }


        private void StartBT_Click(object sender, EventArgs e)
        {
            IsTracking = true;
            if (CurrentTD == null)
            {
                CurrentTD = new TrackDetail() { Project = ProjectTB.Text.Trim(), Start = DateTime.Now, End = DateTime.Now, Task = TaskTB.Text.Trim() };
                using (var ctx = new TimeTrackerContext())
                {
                    ctx.TrackDetails.Add(CurrentTD);
                    ctx.SaveChanges();
                }
            }
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            SaveTime();
            IsTracking = false;
        }

        private void TrackTimer_Tick(object sender, EventArgs e)
        {
            if (IsTracking)
            {
                TimeSpan ts = DateTime.Now.Subtract(CurrentTD.Start);
                TimeTrackedLB.Text = string.Format("{0}:{1}", ts.Minutes, ts.Seconds);
            }
        }

        private void ProjectTB_TextChanged(object sender, EventArgs e)
        {
            if (CurrentTD != null)
            {
                CurrentTD.Project = ProjectTB.Text.Trim();
            }
        }

        private void TaskTB_TextChanged(object sender, EventArgs e)
        {
            if (CurrentTD != null)
            {
                CurrentTD.Task = TaskTB.Text.Trim();
            }
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            SaveTime();
            this.Invoke((MethodInvoker)delegate
            {
                PopupNotifier pn = new PopupNotifier();
                if (IsTracking)
                {
                    pn.TitleText = string.Format("Tracking-{0}", CurrentTD.Project);
                    TimeSpan ts = DateTime.Now.Subtract(CurrentTD.Start);
                    pn.ContentText = string.Format("{0}\n{1}", string.Format("{0}:{1}", ts.Minutes, ts.Seconds), CurrentTD.Task);
                }
                else
                {
                    pn.TitleText = "Tracking";
                    pn.ContentText = "Not Tracking";
                }
               
                pn.Popup();
            });
            
        }

        private void SaveTime()
        {
            if (CurrentTD != null)
            {
                using (var ctx = new TimeTrackerContext())
                {
                    var item = ctx.TrackDetails.FirstOrDefault(t => t.ID == CurrentTD.ID);
                    item.End = DateTime.Now;
                    item.Project = CurrentTD.Project;
                    item.Task = CurrentTD.Task;
                    ctx.SaveChanges();
                    
                }
            }
        }

        private AutoCompleteStringCollection GetProjectList()
        {
            using(var ctx = new TimeTrackerContext())
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.AddRange(ctx.TrackDetails.Select<TrackDetail, string>(x => x.Project).Distinct<string>().ToArray<string>());
                return col;
            }
        }

        private void TodayRptBt_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            rf.FormBorderStyle = FormBorderStyle.FixedSingle;
            rf.ShowDialog();
        }
    }
}

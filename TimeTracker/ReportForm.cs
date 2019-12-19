using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            ReportCalendar.SelectionRange = new SelectionRange(DateTime.Now, DateTime.Now);
            ProjectTB.AutoCompleteCustomSource = GetProjectList();
            PopulateReport();
        }

        private void PopulateReport()
        {
            using (var ctx = new TimeTrackerContext())
            {
                var query = from t in ctx.TrackDetails
                            where t.Start >= ReportCalendar.SelectionRange.Start && t.End <= ReportCalendar.SelectionRange.End &&
 (ProjectTB.Text.Trim() == "" || t.Project.Contains(ProjectTB.Text.Trim()))
                            select t;

                List<TrackReportItem> list = new List<TrackReportItem>();
                
                double minutes = 0;
                foreach(var item in query)
                {
                    TrackReportItem tri = new TrackReportItem() {
                        End = item.End,
                        Minutes = (int)(item.End.Subtract(item.Start).TotalMinutes),
                        Project = item.Project,
                        Start = item.Start,
                        Task = item.Task
                    };
                    list.Add(tri);
                    minutes += item.End.Subtract(item.Start).TotalMinutes;
                }
                ReportGridView.DataSource = list;

                for (int i = 0, j = 0; i <= minutes; i += 60, j++)
                {
                    TotalHoursLabel.Text = string.Format("{0}:{1}", j, (int)(minutes - i));
                }
                
            }
        }

        private AutoCompleteStringCollection GetProjectList()
        {
            using (var ctx = new TimeTrackerContext())
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.AddRange(ctx.TrackDetails.Select<TrackDetail, string>(x => x.Project).Distinct<string>().ToArray<string>());
                return col;
            }
        }

        private void ProjectTB_TextChanged(object sender, EventArgs e)
        {
            PopulateReport();
        }

        private void ReportCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            PopulateReport();
        }
    }
}

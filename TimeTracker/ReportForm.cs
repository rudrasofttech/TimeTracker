﻿using System;
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
            ProjectTB.AutoCompleteCustomSource = GetProjectList();
            PopulateReport();
        }

        private void PopulateReport()
        {
            using (var ctx = new TimeTrackerContext())
            {
                var query = from t in ctx.TrackDetails
                            where t.Start.Year == ReportDatePicker.Value.Year &&
 t.Start.Month == ReportDatePicker.Value.Month && t.Start.Day == ReportDatePicker.Value.Day &&
 (ProjectTB.Text.Trim() == "" || t.Project.Contains(ProjectTB.Text.Trim()))
                            select t;
                List<TrackDetail> list = query.ToList();
                ReportGridView.DataSource = list;
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

        private void ReportDatePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateReport();
        }

        

        private void ProjectTB_TextChanged(object sender, EventArgs e)
        {
            PopulateReport();
        }
    }
}
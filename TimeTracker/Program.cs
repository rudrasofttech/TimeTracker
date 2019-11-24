using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            using (var ctx = new TimeTrackerContext())
            {
                var tt = new TrackDetail() { Project = "Sample", Task = "Sample Task", Start = DateTime.Now };
                ctx.TrackDetails.Add(tt);
                ctx.SaveChanges();
            }
        }
    }
}

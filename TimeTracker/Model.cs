using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    public class TimeTrackerContext : DbContext
    {
        public TimeTrackerContext() : base("name=TimeTracker.Properties.Settings.TTConnectionString")
        {
            //Database.SetInitializer<TimeTrackerContext>(new CreateDatabaseIfNotExists<TimeTrackerContext>());

        }

        public DbSet<TrackDetail> TrackDetails { get; set; }
        public DbSet<TrackShot> TrackShots { get; set; }
    }
    public class TrackDetail
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        public string Project { get; set; }
        [MaxLength(250)]
        public string Task { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

    public class TrackShot
    {
        public int ID { get; set; }
        public DateTime Created { get; set; }
        public byte[] Picture { get; set; }
        public TrackDetail Tracked { get; set; }
    }

    public class TrackReportItem
    {
        public string Project { get; set; }
        public string Task { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Minutes { get; set; }
    }
}

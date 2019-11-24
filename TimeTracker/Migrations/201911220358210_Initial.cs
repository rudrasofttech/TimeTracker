namespace TimeTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrackDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Project = c.String(maxLength: 100),
                        Task = c.String(maxLength: 250),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TrackShots",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        Picture = c.Binary(),
                        Tracked_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TrackDetails", t => t.Tracked_ID)
                .Index(t => t.Tracked_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrackShots", "Tracked_ID", "dbo.TrackDetails");
            DropIndex("dbo.TrackShots", new[] { "Tracked_ID" });
            DropTable("dbo.TrackShots");
            DropTable("dbo.TrackDetails");
        }
    }
}

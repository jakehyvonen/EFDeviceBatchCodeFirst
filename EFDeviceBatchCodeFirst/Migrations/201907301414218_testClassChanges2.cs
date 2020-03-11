namespace EFDeviceBatchCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testClassChanges2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DeviceLJVScanSummaries", "StatsDataPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DeviceLJVScanSummaries", "StatsDataPath");
        }
    }
}

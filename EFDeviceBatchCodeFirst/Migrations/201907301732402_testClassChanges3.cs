namespace EFDeviceBatchCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testClassChanges3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DeviceLJVScanSummaries", "SpreadsheetReportPath", c => c.String());
            AlterColumn("dbo.DeviceLJVScanSummaries", "TestCondition", c => c.String());
            DropColumn("dbo.DeviceLJVScanSummaries", "FilePath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DeviceLJVScanSummaries", "FilePath", c => c.String(nullable: false));
            AlterColumn("dbo.DeviceLJVScanSummaries", "TestCondition", c => c.String(nullable: false));
            DropColumn("dbo.DeviceLJVScanSummaries", "SpreadsheetReportPath");
        }
    }
}

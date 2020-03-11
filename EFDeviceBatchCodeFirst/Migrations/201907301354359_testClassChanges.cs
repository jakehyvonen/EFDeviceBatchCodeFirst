namespace EFDeviceBatchCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testClassChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepositionMethods",
                c => new
                    {
                        DepositionMethodId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DepositionMethodId);
            
            CreateTable(
                "dbo.Layers",
                c => new
                    {
                        LayerId = c.Int(nullable: false, identity: true),
                        PositionIndex = c.Int(nullable: false),
                        Thickness = c.Decimal(precision: 18, scale: 2),
                        Roughness = c.Decimal(precision: 18, scale: 2),
                        Transmittance = c.Decimal(precision: 18, scale: 2),
                        Comment = c.String(),
                        Pattern = c.String(),
                        SheetResistance = c.Decimal(precision: 18, scale: 2),
                        RPM = c.Int(),
                        SpinCoatDuration = c.Int(),
                        AnnealTemp = c.Int(),
                        AnnealDuration = c.Int(),
                        DepositionRate = c.Decimal(precision: 18, scale: 2),
                        BackPressure = c.Decimal(precision: 18, scale: 2),
                        CureCondition = c.String(),
                        CureTime = c.Int(),
                        CoverGlassStyle = c.String(),
                        AmbientEnvironment = c.String(),
                        DispenseVolume = c.Int(),
                        SpreadSheetCellText = c.String(),
                        DepositionMethod_DepositionMethodId = c.Int(),
                        Material_MaterialId = c.Int(),
                        PhysicalRole_PhysicalRoleId = c.Int(),
                        Solution_SolutionId = c.Int(),
                        Device_DeviceId = c.Int(),
                    })
                .PrimaryKey(t => t.LayerId)
                .ForeignKey("dbo.DepositionMethods", t => t.DepositionMethod_DepositionMethodId)
                .ForeignKey("dbo.Materials", t => t.Material_MaterialId)
                .ForeignKey("dbo.PhysicalRoles", t => t.PhysicalRole_PhysicalRoleId)
                .ForeignKey("dbo.Solutions", t => t.Solution_SolutionId)
                .ForeignKey("dbo.Devices", t => t.Device_DeviceId, cascadeDelete: true)
                .Index(t => t.DepositionMethod_DepositionMethodId)
                .Index(t => t.Material_MaterialId)
                .Index(t => t.PhysicalRole_PhysicalRoleId)
                .Index(t => t.Solution_SolutionId)
                .Index(t => t.Device_DeviceId);
            
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        DeviceId = c.Int(nullable: false, identity: true),
                        NumberOfLayers = c.Int(),
                        NumberOfScans = c.Int(),
                        BatchIndex = c.Int(nullable: false),
                        Comment = c.String(),
                        Label = c.String(nullable: false),
                        SpreadSheetStructure = c.String(),
                        DeviceBatch_DeviceBatchId = c.Int(),
                        QDBatch_MaterialId = c.Int(),
                    })
                .PrimaryKey(t => t.DeviceId)
                .ForeignKey("dbo.DeviceBatches", t => t.DeviceBatch_DeviceBatchId, cascadeDelete: true)
                .ForeignKey("dbo.Materials", t => t.QDBatch_MaterialId)
                .Index(t => t.DeviceBatch_DeviceBatchId)
                .Index(t => t.QDBatch_MaterialId);
            
            CreateTable(
                "dbo.DeviceBatches",
                c => new
                    {
                        DeviceBatchId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Size = c.Int(nullable: false),
                        FabDate = c.DateTime(nullable: false),
                        FinishTime = c.Time(precision: 7),
                        Notes = c.String(),
                        FilePath = c.String(nullable: false),
                        SpreadSheetPath = c.String(nullable: false),
                        Employee_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.DeviceBatchId)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeId)
                .Index(t => t.Employee_EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.EquipmentTasks",
                c => new
                    {
                        EquipmentTaskId = c.Int(nullable: false, identity: true),
                        ScheduledDate = c.DateTime(),
                        IsCompleted = c.Boolean(nullable: false),
                        Device_DeviceId = c.Int(),
                        DeviceBatch_DeviceBatchId = c.Int(),
                        Employee_EmployeeId = c.Int(),
                        EquipmentResource_EquipmentResourceId = c.Int(),
                    })
                .PrimaryKey(t => t.EquipmentTaskId)
                .ForeignKey("dbo.Devices", t => t.Device_DeviceId)
                .ForeignKey("dbo.DeviceBatches", t => t.DeviceBatch_DeviceBatchId)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeId)
                .ForeignKey("dbo.EquipmentResources", t => t.EquipmentResource_EquipmentResourceId)
                .Index(t => t.Device_DeviceId)
                .Index(t => t.DeviceBatch_DeviceBatchId)
                .Index(t => t.Employee_EmployeeId)
                .Index(t => t.EquipmentResource_EquipmentResourceId);
            
            CreateTable(
                "dbo.EquipmentResources",
                c => new
                    {
                        EquipmentResourceId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        IsAvailable = c.Boolean(nullable: false),
                        ChannelsAvailable = c.Int(),
                    })
                .PrimaryKey(t => t.EquipmentResourceId);
            
            CreateTable(
                "dbo.DeviceLJVScanSummaries",
                c => new
                    {
                        DeviceLJVScanSummaryId = c.Int(nullable: false, identity: true),
                        MaxEQE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MeanOfMaxEQE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StdDevOfMaxEQE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxCE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MeanOfMaxCE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StdDevOfMaxCE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Max1kNitsEQE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MeanAt1kNitsEQE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StdDevAt1kNitsEQE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxAt1kNitsCE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MeanAt1kNitsCE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StdDevAt1kNitsCE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ELPeakLambda = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ELFWHM = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FilePath = c.String(nullable: false),
                        TestCondition = c.String(nullable: false),
                        MeanLuminanceAtMaxEQE = c.Decimal(precision: 18, scale: 2),
                        Device_DeviceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DeviceLJVScanSummaryId)
                .ForeignKey("dbo.Devices", t => t.Device_DeviceId, cascadeDelete: true)
                .Index(t => t.Device_DeviceId);
            
            CreateTable(
                "dbo.ELSpectrums",
                c => new
                    {
                        ELSpectrumId = c.Int(nullable: false, identity: true),
                        ELPeakLambda = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ELFWHM = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CIEx = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CIEy = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FilePath = c.String(nullable: false),
                        DeviceLJVScanSummary_DeviceLJVScanSummaryId = c.Int(),
                        Pixel_PixelId = c.Int(nullable: false),
                        QDBatch_MaterialId = c.Int(),
                    })
                .PrimaryKey(t => t.ELSpectrumId)
                .ForeignKey("dbo.DeviceLJVScanSummaries", t => t.DeviceLJVScanSummary_DeviceLJVScanSummaryId)
                .ForeignKey("dbo.Pixels", t => t.Pixel_PixelId, cascadeDelete: true)
                .ForeignKey("dbo.Materials", t => t.QDBatch_MaterialId)
                .Index(t => t.DeviceLJVScanSummary_DeviceLJVScanSummaryId)
                .Index(t => t.Pixel_PixelId)
                .Index(t => t.QDBatch_MaterialId);
            
            CreateTable(
                "dbo.Pixels",
                c => new
                    {
                        PixelId = c.Int(nullable: false, identity: true),
                        Site = c.String(nullable: false),
                        Device_DeviceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PixelId)
                .ForeignKey("dbo.Devices", t => t.Device_DeviceId, cascadeDelete: true)
                .Index(t => t.Device_DeviceId);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageId = c.Int(nullable: false),
                        FilePath = c.String(nullable: false),
                        Luminance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Voltage = c.Decimal(precision: 18, scale: 2),
                        Current = c.Decimal(precision: 18, scale: 2),
                        DeviceLJVScanSummary_DeviceLJVScanSummaryId = c.Int(),
                        Pixel_PixelId = c.Int(),
                    })
                .PrimaryKey(t => t.ImageId)
                .ForeignKey("dbo.DeviceLJVScanSummaries", t => t.DeviceLJVScanSummary_DeviceLJVScanSummaryId)
                .ForeignKey("dbo.LJVScans", t => t.ImageId, cascadeDelete: true)
                .ForeignKey("dbo.Pixels", t => t.Pixel_PixelId)
                .Index(t => t.ImageId)
                .Index(t => t.DeviceLJVScanSummary_DeviceLJVScanSummaryId)
                .Index(t => t.Pixel_PixelId);
            
            CreateTable(
                "dbo.LJVScans",
                c => new
                    {
                        LJVScanId = c.Int(nullable: false, identity: true),
                        MaxEQE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxCE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxPE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxVoltage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        At1kNitsEQE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        At1kNitsCE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        At1kNitsCurrentDensity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        At1kNitsVoltage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        At500NitsEQE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        At500NitsCE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        At500NitsCurrentDensity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        At500NitsVoltage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProcDATFilePath = c.String(nullable: false),
                        RawDATFilePath = c.String(),
                        FullDATFilePath = c.String(),
                        Alpha = c.Double(),
                        LuminanceAtMaxEQE = c.Decimal(precision: 18, scale: 2),
                        TimeWhenAcquired = c.DateTime(),
                        PixelLitUp = c.Boolean(),
                        DeviceLJVScanSummary_DeviceLJVScanSummaryId = c.Int(nullable: false),
                        Pixel_PixelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LJVScanId)
                .ForeignKey("dbo.DeviceLJVScanSummaries", t => t.DeviceLJVScanSummary_DeviceLJVScanSummaryId, cascadeDelete: true)
                .ForeignKey("dbo.Pixels", t => t.Pixel_PixelId)
                .Index(t => t.DeviceLJVScanSummary_DeviceLJVScanSummaryId)
                .Index(t => t.Pixel_PixelId);
            
            CreateTable(
                "dbo.LJVScanSpecs",
                c => new
                    {
                        LJVScanSpecId = c.Int(nullable: false),
                        StartVoltage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StopVoltage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StepSize = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StopCurrent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StopLuminance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ActiveArea = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ShouldRecordSpectrumAtEachStep = c.Boolean(nullable: false),
                        DeviceDwellTime = c.Int(nullable: false),
                        TestCondition = c.String(),
                    })
                .PrimaryKey(t => t.LJVScanSpecId)
                .ForeignKey("dbo.LJVScans", t => t.LJVScanSpecId, cascadeDelete: true)
                .Index(t => t.LJVScanSpecId);
            
            CreateTable(
                "dbo.Lifetimes",
                c => new
                    {
                        LifetimeId = c.Int(nullable: false),
                        InitialLuminance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SetCurrent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InitialEQE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TimeUntil97Percent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TimeUntil90Percent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TimeUntil50Percent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InitialCE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FilePath = c.String(nullable: false),
                        StartDateTime = c.DateTime(),
                        SetCurrentDensity = c.Decimal(precision: 18, scale: 2),
                        TotalHoursElapsed = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.LifetimeId)
                .ForeignKey("dbo.Pixels", t => t.LifetimeId)
                .Index(t => t.LifetimeId);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        MaterialId = c.Int(nullable: false, identity: true),
                        Supplier = c.String(),
                        DateReceivedOrSynthesized = c.DateTime(),
                        Name = c.String(nullable: false),
                        ExpirationDate = c.DateTime(),
                        LotNumber = c.String(),
                        PartNumber = c.String(),
                        Color = c.String(),
                        PLPeakLambda = c.Decimal(precision: 18, scale: 2),
                        PLFWHM = c.Decimal(precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        DepositionMethod_DepositionMethodId = c.Int(),
                        PhysicalRole_PhysicalRoleId = c.Int(),
                    })
                .PrimaryKey(t => t.MaterialId)
                .ForeignKey("dbo.DepositionMethods", t => t.DepositionMethod_DepositionMethodId)
                .ForeignKey("dbo.PhysicalRoles", t => t.PhysicalRole_PhysicalRoleId)
                .Index(t => t.DepositionMethod_DepositionMethodId)
                .Index(t => t.PhysicalRole_PhysicalRoleId);
            
            CreateTable(
                "dbo.LayerTemplates",
                c => new
                    {
                        LayerTemplateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LayerTemplateId)
                .ForeignKey("dbo.Materials", t => t.LayerTemplateId)
                .ForeignKey("dbo.Layers", t => t.LayerTemplateId)
                .Index(t => t.LayerTemplateId);
            
            CreateTable(
                "dbo.PhysicalRoles",
                c => new
                    {
                        PhysicalRoleId = c.Int(nullable: false, identity: true),
                        ShortName = c.String(nullable: false),
                        LongName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PhysicalRoleId);
            
            CreateTable(
                "dbo.Solutions",
                c => new
                    {
                        SolutionId = c.Int(nullable: false, identity: true),
                        InitialVolume = c.Decimal(precision: 18, scale: 2),
                        Concentration = c.Decimal(precision: 18, scale: 2),
                        DatePreparedOrPurified = c.DateTime(),
                        Solvent = c.String(),
                        Label = c.String(),
                        Material_MaterialId = c.Int(),
                    })
                .PrimaryKey(t => t.SolutionId)
                .ForeignKey("dbo.Materials", t => t.Material_MaterialId)
                .Index(t => t.Material_MaterialId);
            
            CreateTable(
                "dbo.PLSpectrums",
                c => new
                    {
                        PLSpectrumId = c.Int(nullable: false, identity: true),
                        PeakLambda = c.Decimal(precision: 18, scale: 2),
                        FWHM = c.Decimal(precision: 18, scale: 2),
                        CIEx = c.Decimal(precision: 18, scale: 2),
                        CIEy = c.Decimal(precision: 18, scale: 2),
                        FilePath = c.String(),
                        QDBatch_MaterialId = c.Int(),
                    })
                .PrimaryKey(t => t.PLSpectrumId)
                .ForeignKey("dbo.Materials", t => t.QDBatch_MaterialId)
                .Index(t => t.QDBatch_MaterialId);
            
            CreateTable(
                "dbo.DeviceTemplates",
                c => new
                    {
                        DeviceTemplateId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        EmissionType = c.String(nullable: false),
                        Structure = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DeviceTemplateId)
                .ForeignKey("dbo.Devices", t => t.DeviceTemplateId)
                .Index(t => t.DeviceTemplateId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LayerTemplates", "LayerTemplateId", "dbo.Layers");
            DropForeignKey("dbo.Layers", "Device_DeviceId", "dbo.Devices");
            DropForeignKey("dbo.DeviceTemplates", "DeviceTemplateId", "dbo.Devices");
            DropForeignKey("dbo.PLSpectrums", "QDBatch_MaterialId", "dbo.Materials");
            DropForeignKey("dbo.Solutions", "Material_MaterialId", "dbo.Materials");
            DropForeignKey("dbo.Layers", "Solution_SolutionId", "dbo.Solutions");
            DropForeignKey("dbo.Materials", "PhysicalRole_PhysicalRoleId", "dbo.PhysicalRoles");
            DropForeignKey("dbo.Layers", "PhysicalRole_PhysicalRoleId", "dbo.PhysicalRoles");
            DropForeignKey("dbo.LayerTemplates", "LayerTemplateId", "dbo.Materials");
            DropForeignKey("dbo.Layers", "Material_MaterialId", "dbo.Materials");
            DropForeignKey("dbo.Materials", "DepositionMethod_DepositionMethodId", "dbo.DepositionMethods");
            DropForeignKey("dbo.ELSpectrums", "QDBatch_MaterialId", "dbo.Materials");
            DropForeignKey("dbo.Devices", "QDBatch_MaterialId", "dbo.Materials");
            DropForeignKey("dbo.ELSpectrums", "Pixel_PixelId", "dbo.Pixels");
            DropForeignKey("dbo.Lifetimes", "LifetimeId", "dbo.Pixels");
            DropForeignKey("dbo.Images", "Pixel_PixelId", "dbo.Pixels");
            DropForeignKey("dbo.LJVScans", "Pixel_PixelId", "dbo.Pixels");
            DropForeignKey("dbo.LJVScanSpecs", "LJVScanSpecId", "dbo.LJVScans");
            DropForeignKey("dbo.Images", "ImageId", "dbo.LJVScans");
            DropForeignKey("dbo.LJVScans", "DeviceLJVScanSummary_DeviceLJVScanSummaryId", "dbo.DeviceLJVScanSummaries");
            DropForeignKey("dbo.Images", "DeviceLJVScanSummary_DeviceLJVScanSummaryId", "dbo.DeviceLJVScanSummaries");
            DropForeignKey("dbo.Pixels", "Device_DeviceId", "dbo.Devices");
            DropForeignKey("dbo.ELSpectrums", "DeviceLJVScanSummary_DeviceLJVScanSummaryId", "dbo.DeviceLJVScanSummaries");
            DropForeignKey("dbo.DeviceLJVScanSummaries", "Device_DeviceId", "dbo.Devices");
            DropForeignKey("dbo.Devices", "DeviceBatch_DeviceBatchId", "dbo.DeviceBatches");
            DropForeignKey("dbo.EquipmentTasks", "EquipmentResource_EquipmentResourceId", "dbo.EquipmentResources");
            DropForeignKey("dbo.EquipmentTasks", "Employee_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.EquipmentTasks", "DeviceBatch_DeviceBatchId", "dbo.DeviceBatches");
            DropForeignKey("dbo.EquipmentTasks", "Device_DeviceId", "dbo.Devices");
            DropForeignKey("dbo.DeviceBatches", "Employee_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Layers", "DepositionMethod_DepositionMethodId", "dbo.DepositionMethods");
            DropIndex("dbo.DeviceTemplates", new[] { "DeviceTemplateId" });
            DropIndex("dbo.PLSpectrums", new[] { "QDBatch_MaterialId" });
            DropIndex("dbo.Solutions", new[] { "Material_MaterialId" });
            DropIndex("dbo.LayerTemplates", new[] { "LayerTemplateId" });
            DropIndex("dbo.Materials", new[] { "PhysicalRole_PhysicalRoleId" });
            DropIndex("dbo.Materials", new[] { "DepositionMethod_DepositionMethodId" });
            DropIndex("dbo.Lifetimes", new[] { "LifetimeId" });
            DropIndex("dbo.LJVScanSpecs", new[] { "LJVScanSpecId" });
            DropIndex("dbo.LJVScans", new[] { "Pixel_PixelId" });
            DropIndex("dbo.LJVScans", new[] { "DeviceLJVScanSummary_DeviceLJVScanSummaryId" });
            DropIndex("dbo.Images", new[] { "Pixel_PixelId" });
            DropIndex("dbo.Images", new[] { "DeviceLJVScanSummary_DeviceLJVScanSummaryId" });
            DropIndex("dbo.Images", new[] { "ImageId" });
            DropIndex("dbo.Pixels", new[] { "Device_DeviceId" });
            DropIndex("dbo.ELSpectrums", new[] { "QDBatch_MaterialId" });
            DropIndex("dbo.ELSpectrums", new[] { "Pixel_PixelId" });
            DropIndex("dbo.ELSpectrums", new[] { "DeviceLJVScanSummary_DeviceLJVScanSummaryId" });
            DropIndex("dbo.DeviceLJVScanSummaries", new[] { "Device_DeviceId" });
            DropIndex("dbo.EquipmentTasks", new[] { "EquipmentResource_EquipmentResourceId" });
            DropIndex("dbo.EquipmentTasks", new[] { "Employee_EmployeeId" });
            DropIndex("dbo.EquipmentTasks", new[] { "DeviceBatch_DeviceBatchId" });
            DropIndex("dbo.EquipmentTasks", new[] { "Device_DeviceId" });
            DropIndex("dbo.DeviceBatches", new[] { "Employee_EmployeeId" });
            DropIndex("dbo.Devices", new[] { "QDBatch_MaterialId" });
            DropIndex("dbo.Devices", new[] { "DeviceBatch_DeviceBatchId" });
            DropIndex("dbo.Layers", new[] { "Device_DeviceId" });
            DropIndex("dbo.Layers", new[] { "Solution_SolutionId" });
            DropIndex("dbo.Layers", new[] { "PhysicalRole_PhysicalRoleId" });
            DropIndex("dbo.Layers", new[] { "Material_MaterialId" });
            DropIndex("dbo.Layers", new[] { "DepositionMethod_DepositionMethodId" });
            DropTable("dbo.DeviceTemplates");
            DropTable("dbo.PLSpectrums");
            DropTable("dbo.Solutions");
            DropTable("dbo.PhysicalRoles");
            DropTable("dbo.LayerTemplates");
            DropTable("dbo.Materials");
            DropTable("dbo.Lifetimes");
            DropTable("dbo.LJVScanSpecs");
            DropTable("dbo.LJVScans");
            DropTable("dbo.Images");
            DropTable("dbo.Pixels");
            DropTable("dbo.ELSpectrums");
            DropTable("dbo.DeviceLJVScanSummaries");
            DropTable("dbo.EquipmentResources");
            DropTable("dbo.EquipmentTasks");
            DropTable("dbo.Employees");
            DropTable("dbo.DeviceBatches");
            DropTable("dbo.Devices");
            DropTable("dbo.Layers");
            DropTable("dbo.DepositionMethods");
        }
    }
}

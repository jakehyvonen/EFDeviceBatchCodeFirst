using System.Data.Entity;
using EFDeviceBatchCodeFirst.Configurations;

namespace EFDeviceBatchCodeFirst
{
    public class DeviceBatchContext : DbContext
    {
        public DeviceBatchContext(string connString = "name=ServerConnectionString") : base(connString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DeviceBatchContext, Migrations.Configuration>());
            //Database.SetInitializer<DeviceBatchContext>(new DeviceBatchDBInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LJVScanConfiguration());
            modelBuilder.Configurations.Add(new PixelConfiguration());
            modelBuilder.Configurations.Add(new LayerConfiguration());
            modelBuilder.Configurations.Add(new MaterialConfiguration());
            modelBuilder.Configurations.Add(new DeviceConfiguration());
            modelBuilder.Configurations.Add(new ELSpectrumConfiguration());
            modelBuilder.Configurations.Add(new DeviceLJVScanSummaryConfiguration());
        }
        public virtual DbSet<DeviceBatch> DeviceBatches { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Layer> Layers { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Pixel> Pixels { get; set; }
        public virtual DbSet<DeviceTemplate> DeviceTemplates { get; set; }
        public virtual DbSet<DeviceLJVScanSummary> DeviceLJVScanSummaries { get; set; }
        public virtual DbSet<LJVScan> LJVScans { get; set; }
        public virtual DbSet<ELSpectrum> ELSpectra { get; set; }
        public virtual DbSet<Solution> Solutions { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Lifetime> Lifetimes { get; set; }
        public virtual DbSet<PhysicalRole> PhysicalRoles { get; set; }
        public virtual DbSet<DepositionMethod> DepositionMethods { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<LayerTemplate> LayerTemplates { get; set; }
        public virtual DbSet<PLSpectrum> PLSpectrums { get; set; }
        public virtual DbSet<EquipmentResource> EquipmentResources { get; set; }
        public virtual DbSet<EquipmentTask> EquipmentTasks { get; set; }
    }

}

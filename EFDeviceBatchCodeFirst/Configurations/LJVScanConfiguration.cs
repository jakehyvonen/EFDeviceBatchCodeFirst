using System.Data.Entity.ModelConfiguration;

namespace EFDeviceBatchCodeFirst.Configurations
{
    public class LJVScanConfiguration : EntityTypeConfiguration<LJVScan>
    {
        public LJVScanConfiguration()
        {
            this.HasOptional(l => l.Image)
                .WithRequired(i => i.LJVScan)
                .WillCascadeOnDelete(true);
            this.HasOptional(ls => ls.LJVScanSpec)
                .WithRequired(l => l.LJVScan)
                .WillCascadeOnDelete(true);
            this.HasRequired<DeviceLJVScanSummary>(l => l.DeviceLJVScanSummary)
               .WithMany(d => d.LJVScans)
               .WillCascadeOnDelete(true);            
            this.HasRequired<Pixel>(l => l.Pixel)
               .WithMany(p => p.LJVScans)
               .WillCascadeOnDelete(false);          
        }
    }
}

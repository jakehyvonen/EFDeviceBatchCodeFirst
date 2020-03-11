using System.Data.Entity.ModelConfiguration;

namespace EFDeviceBatchCodeFirst.Configurations
{
    public class PixelConfiguration : EntityTypeConfiguration<Pixel>
    {
        public PixelConfiguration()
        {
            this.HasOptional(p => p.Lifetime)
                .WithRequired(l => l.Pixel);
            this.HasRequired<Device>(p => p.Device)
                .WithMany(d => d.Pixels)
                .WillCascadeOnDelete(true);
            /*
            this.HasMany<LJVScan>(p => p.LJVScans)
                .WithRequired(l => l.Pixel)
                .WillCascadeOnDelete(true);
                */
        }
    }
}

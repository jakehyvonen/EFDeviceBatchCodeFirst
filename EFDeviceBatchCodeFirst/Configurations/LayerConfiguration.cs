using System.Data.Entity.ModelConfiguration;

namespace EFDeviceBatchCodeFirst.Configurations
{
    public class LayerConfiguration : EntityTypeConfiguration<Layer>
    {
        public LayerConfiguration()
        {
            this.HasOptional(l => l.LayerTemplate)
                .WithRequired(lt => lt.Layer);
            this.HasOptional<Device>(l => l.Device)
               .WithMany(d => d.Layers)
               .WillCascadeOnDelete(true);
            /*
            this.HasOptional<Material>(l => l.Material)
                .WithMany(m => m.Layers)
                .HasForeignKey<int?>(l => l.MaterialId);
            this.HasRequired<PhysicalRole>(l => l.PhysicalRole)
                .WithMany(p => p.Layers)
                .HasForeignKey<int>(l => l.PhysicalRoleId);
            this.HasOptional<DepositionMethod>(l => l.DepositionMethod)
                .WithMany(d => d.Layers)
                .HasForeignKey<int?>(l => l.DepositionMethodId);
            this.HasOptional<Device>(l => l.Device)
                .WithMany(d => d.Layers)
                .HasForeignKey<int?>(l => l.DeviceId)
                .WillCascadeOnDelete(true);
            */
        }
    }
}

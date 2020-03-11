using System.Data.Entity.ModelConfiguration;

namespace EFDeviceBatchCodeFirst.Configurations
{
    public class MaterialConfiguration : EntityTypeConfiguration<Material>
    {
        public MaterialConfiguration()
        {
            this.HasOptional(m => m.LayerTemplate)
                .WithRequired(lt => lt.Material);
            /*
            this.HasRequired<DepositionMethod>(m => m.DepositionMethod)
                .WithMany(d => d.Materials)
                .HasForeignKey<int>(m=>m.DepositionMethodId)
                .WillCascadeOnDelete(false);
            this.HasRequired<PhysicalRole>(m => m.PhysicalRole)
                .WithMany(p => p.Materials)
                .HasForeignKey<int>(m => m.PhysicalRoleId)
                .WillCascadeOnDelete(false);
            */
        }
    }
}

using System.Data.Entity.ModelConfiguration;

namespace EFDeviceBatchCodeFirst.Configurations
{
    public class ELSpectrumConfiguration : EntityTypeConfiguration<ELSpectrum>
    {
        public ELSpectrumConfiguration()
        {
            this.HasRequired<Pixel>(es => es.Pixel)
                .WithMany(p => p.ELSpectrums)
                .WillCascadeOnDelete(true);
            
        }
    }
}

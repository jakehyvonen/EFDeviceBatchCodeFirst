using System.Data.Entity.ModelConfiguration;


namespace EFDeviceBatchCodeFirst.Configurations
{
    public class DeviceLJVScanSummaryConfiguration : EntityTypeConfiguration<DeviceLJVScanSummary>
    {
        public DeviceLJVScanSummaryConfiguration()
        {
            this.HasRequired<Device>(dls => dls.Device)
                .WithMany(d => d.DeviceLJVScanSummaries)
                .WillCascadeOnDelete(true);
        }
    }
}

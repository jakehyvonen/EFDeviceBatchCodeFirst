using System.Data.Entity.ModelConfiguration;

namespace EFDeviceBatchCodeFirst.Configurations
{
    public class DeviceConfiguration : EntityTypeConfiguration<Device>
    {
        public DeviceConfiguration()
        {
            this.HasOptional(d => d.DeviceTemplate)
                .WithRequired(dt => dt.Device);
            this.HasOptional(d => d.DeviceBatch)
                .WithMany(db => db.Devices)
                .WillCascadeOnDelete(true);
            /*
            this.HasOptional<DeviceBatch>(d => d.DeviceBatch)
                .WithMany(db => db.Devices)
                .HasForeignKey<int?>(d => d.DeviceBatchId)
                .WillCascadeOnDelete(true);           
            */
        }
    }
}

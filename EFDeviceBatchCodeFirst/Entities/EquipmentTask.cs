using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDeviceBatchCodeFirst
{
    public partial class EquipmentTask
    {
        [Key]
        public int EquipmentTaskId { get; set; }
        /*
        [ForeignKey("EquipmentResource")]
        public int EquipmentResourceId { get; set; }
        [ForeignKey("Employee")]
        public Nullable<int> EmployeeId { get; set; }
        [ForeignKey("Device")]
        public Nullable<int> DeviceId { get; set; }
        [ForeignKey("DeviceBatch")]
        public Nullable<int> DeviceBatchId { get; set; }
        */
        public Nullable<System.DateTime> ScheduledDate { get; set; }

        [Required]
        public bool IsCompleted { get; set; }

        public virtual EquipmentResource EquipmentResource { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Device Device { get; set; }
        public virtual DeviceBatch DeviceBatch { get; set; }
    }

}

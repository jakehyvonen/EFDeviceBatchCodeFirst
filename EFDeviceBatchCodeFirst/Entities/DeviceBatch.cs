using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDeviceBatchCodeFirst
{
    public partial class DeviceBatch
    {
        public DeviceBatch()
        {
            this.Devices = new HashSet<Device>();
            this.EquipmentTasks = new HashSet<EquipmentTask>();
        }
        [Key]
        public int DeviceBatchId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public System.DateTime FabDate { get; set; }
        public Nullable<System.TimeSpan> FinishTime { get; set; }
        public string Notes { get; set; }
        [Required]
        public string FilePath { get; set; }
        [Required]
        public string SpreadSheetPath { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<EquipmentTask> EquipmentTasks { get; set; }
    }

}

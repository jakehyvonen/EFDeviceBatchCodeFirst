using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDeviceBatchCodeFirst
{
    public partial class Device
    {
        public Device()
        {
            this.Pixels = new HashSet<Pixel>();
            this.DeviceLJVScanSummaries = new HashSet<DeviceLJVScanSummary>();
            this.Layers = new HashSet<Layer>();
            this.EquipmentTasks = new HashSet<EquipmentTask>();
        }
        [Key]
        public int DeviceId { get; private set; }
        public Nullable<int> NumberOfLayers { get; set; }
        public Nullable<int> NumberOfScans { get; set; }
        [Required]
        public int BatchIndex { get; set; }
        public string Comment { get; set; }
        [Required]
        public string Label { get; set; }       
        public string SpreadSheetStructure { get; set; }

        public virtual ICollection<Pixel> Pixels { get; set; }
        public virtual ICollection<DeviceLJVScanSummary> DeviceLJVScanSummaries { get; set; }
        public virtual QDBatch QDBatch { get; set; }
        public virtual DeviceBatch DeviceBatch { get; set; }
        public virtual DeviceTemplate DeviceTemplate { get; set; }
        public virtual ICollection<Layer> Layers { get; set; }
        public virtual ICollection<EquipmentTask> EquipmentTasks { get; set; }
      
    }

}

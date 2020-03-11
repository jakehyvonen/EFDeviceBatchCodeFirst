using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDeviceBatchCodeFirst
{
    public partial class EquipmentResource
    {
        public EquipmentResource()
        {
            this.EquipmentTasks = new HashSet<EquipmentTask>();
        }
        [Key]
        public int EquipmentResourceId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
        public Nullable<int> ChannelsAvailable { get; set; }

        public virtual ICollection<EquipmentTask> EquipmentTasks { get; set; }
    }

}

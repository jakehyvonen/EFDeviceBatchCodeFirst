using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDeviceBatchCodeFirst
{
    public partial class Employee
    {
        public Employee()
        {
            this.DeviceBatches = new HashSet<DeviceBatch>();
            this.EquipmentTask = new HashSet<EquipmentTask>();
        }
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public virtual ICollection<DeviceBatch> DeviceBatches { get; set; }
        public virtual ICollection<EquipmentTask> EquipmentTask { get; set; }
    }

}

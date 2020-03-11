using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDeviceBatchCodeFirst
{
    public partial class PhysicalRole
    {
        public PhysicalRole()
        {
            this.Materials = new HashSet<Material>();
            this.Layers = new HashSet<Layer>();
        }
        [Key]
        public int PhysicalRoleId { get; set; }
        [Required]
        public string ShortName { get; set; }
        [Required]
        public string LongName { get; set; }

        public virtual ICollection<Material> Materials { get; set; }
        public virtual ICollection<Layer> Layers { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDeviceBatchCodeFirst
{
    public partial class DepositionMethod
    {
        public DepositionMethod()
        {
            this.Materials = new HashSet<Material>();
            this.Layers = new HashSet<Layer>();
        }
        [Key]
        public int DepositionMethodId { get; set; }    
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Material> Materials { get; set; }
        public virtual ICollection<Layer> Layers { get; set; }
    }
}

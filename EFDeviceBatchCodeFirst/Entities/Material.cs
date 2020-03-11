using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDeviceBatchCodeFirst
{
    public partial class Material
    {
        public Material()
        {
            this.Solutions = new HashSet<Solution>();
            this.Layers = new HashSet<Layer>();
        }
        [Key]
        public int MaterialId { get; set; }
        public string Supplier { get; set; }
        public Nullable<System.DateTime> DateReceivedOrSynthesized { get; set; }
        [Required]
        public string Name { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public string LotNumber { get; set; }
        /*
        [ForeignKey("PhysicalRole")]
        public int PhysicalRoleId { get; set; }
        [ForeignKey("DepositionMethod")]
        public int DepositionMethodId { get; set; }
        */
        public string PartNumber { get; set; }

        public virtual ICollection<Solution> Solutions { get; set; }
        public virtual PhysicalRole PhysicalRole { get; set; }
        public virtual DepositionMethod DepositionMethod { get; set; }
        public virtual ICollection<Layer> Layers { get; set; }
        public virtual LayerTemplate LayerTemplate { get; set; }
    }

}

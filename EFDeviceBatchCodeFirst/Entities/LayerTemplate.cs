using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDeviceBatchCodeFirst
{
    public partial class LayerTemplate
    {
        [Key]
        public int LayerTemplateId { get; set; }
        /*
        [ForeignKey("Layer")]
        public int LayerId { get; set; }
        [ForeignKey("Material")]
        public int MaterialId { get; set; }
        */
        public virtual Layer Layer { get; set; }
        public virtual Material Material { get; set; }
    }

}

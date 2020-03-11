using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDeviceBatchCodeFirst
{
    public partial class DeviceTemplate
    {
        [Key]
        public int DeviceTemplateId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string EmissionType { get; set; }
        [Required]
        public string Structure { get; set; }
        /*
        [ForeignKey("Device")]
        public int DeviceId { get; set; }
        */
        public virtual Device Device { get; set; }
    }

}

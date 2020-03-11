using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDeviceBatchCodeFirst
{
    public partial class Image
    {      
        [Key]
        public int ImageId { get; set; }
        [Required]
        public string FilePath { get; set; }
        [Required]
        public byte[] RawImage { get; set; }
        public decimal Luminance { get; set; }
        public Nullable<decimal> Voltage { get; set; }
        public Nullable<decimal> Current { get; set; }      
        public virtual Pixel Pixel { get; set; }
        public virtual LJVScan LJVScan { get; set; }
    }

}

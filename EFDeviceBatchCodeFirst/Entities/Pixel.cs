using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDeviceBatchCodeFirst
{
    public partial class Pixel
    {
        public Pixel()
        {
            this.ELSpectrums = new HashSet<ELSpectrum>();
            this.LJVScans = new HashSet<LJVScan>();
            this.Images = new HashSet<Image>();
        }
        [Key]
        public int PixelId { get; set; }
        [Required]
        public string Site { get; set; }       
        public virtual Device Device { get; set; }
        public virtual ICollection<ELSpectrum> ELSpectrums { get; set; }
        public virtual ICollection<LJVScan> LJVScans { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual Lifetime Lifetime { get; set; }
    }

}

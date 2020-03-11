using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDeviceBatchCodeFirst
{
    public partial class LJVScan
    {
        [Key]
        public int LJVScanId { get; set; }
        [Required]
        public decimal MaxEQE { get; set; }
        [Required]
        public decimal MaxCE { get; set; }
        [Required]
        public decimal MaxPE { get; set; }
        [Required]
        public decimal MaxVoltage { get; set; }
        [Required]
        public decimal At1kNitsEQE { get; set; }
        [Required]
        public decimal At1kNitsCE { get; set; }
        [Required]
        public decimal At1kNitsCurrentDensity { get; set; }
        [Required]
        public decimal At1kNitsVoltage { get; set; }
        [Required]
        public decimal At500NitsEQE { get; set; }
        [Required]
        public decimal At500NitsCE { get; set; }
        [Required]
        public decimal At500NitsCurrentDensity { get; set; }
        [Required]
        public decimal At500NitsVoltage { get; set; }
        [Required]
        public string ProcDATFilePath { get; set; }
        public string RawDATFilePath { get; set; }
        public string FullDATFilePath { get; set; }
        public Nullable<double> Alpha { get; set; }
        public Nullable<decimal> LuminanceAtMaxEQE { get; set; }
        public Nullable<System.DateTime> TimeWhenAcquired { get; set; }
        public Nullable<bool> PixelLitUp { get; set; }

        public virtual Pixel Pixel { get; set; }
        public virtual DeviceLJVScanSummary DeviceLJVScanSummary { get; set; }
        public virtual Image Image { get; set; }
        public virtual LJVScanSpec LJVScanSpec { get; set; }
    }

}

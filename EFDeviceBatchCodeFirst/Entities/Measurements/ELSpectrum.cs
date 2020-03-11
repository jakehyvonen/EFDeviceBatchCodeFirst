using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDeviceBatchCodeFirst
{
    public partial class ELSpectrum
    {
        [Key]
        public int ELSpectrumId { get; set; }
        [Required]
        public decimal ELPeakLambda { get; set; }
        [Required]
        public decimal ELFWHM { get; set; }
        [Required]
        public decimal CIEx { get; set; }
        [Required]
        public decimal CIEy { get; set; }
        [Required]
        public string FilePath { get; set; }
        /*
        [ForeignKey("Pixel")]
        public int PixelId { get; set; }       
        [ForeignKey("DeviceLJVScanSummary")]
        public int DeviceLJVScanSummaryId { get; set; }
        [ForeignKey("QDBatch")]
        public int QDBatchId { get; set; }
        */
        public virtual Pixel Pixel { get; set; }
        public virtual DeviceLJVScanSummary DeviceLJVScanSummary { get; set; }
        public virtual QDBatch QDBatch { get; set; }
    }

}

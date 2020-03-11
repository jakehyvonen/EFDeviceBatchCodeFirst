using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDeviceBatchCodeFirst
{
    public partial class PLSpectrum
    {
        [Key]
        public int PLSpectrumId { get; set; }
        /*
        [ForeignKey("QDBatch")]
        public int QDBatchId { get; set; }
        */
        public Nullable<decimal> PeakLambda { get; set; }
        public Nullable<decimal> FWHM { get; set; }
        public Nullable<decimal> CIEx { get; set; }
        public Nullable<decimal> CIEy { get; set; }
        public string FilePath { get; set; }

        public virtual QDBatch QDBatch { get; set; }
    }
}

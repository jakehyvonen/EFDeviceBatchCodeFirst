using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDeviceBatchCodeFirst
{
    public partial class DeviceLJVScanSummary
    {
        public DeviceLJVScanSummary()
        {
            this.ELSpectrums = new HashSet<ELSpectrum>();
            this.LJVScans = new HashSet<LJVScan>();
            this.Images = new HashSet<Image>();
        }
        [Key]
        public int DeviceLJVScanSummaryId { get; set; }
        [Required]
        public decimal MaxEQE { get; set; }
        [Required]
        public decimal MeanOfMaxEQE { get; set; }
        [Required]
        public decimal StdDevOfMaxEQE { get; set; }
        [Required]
        public decimal MaxCE { get; set; }
        [Required]
        public decimal MeanOfMaxCE { get; set; }
        [Required]
        public decimal StdDevOfMaxCE { get; set; }
        [Required]
        public decimal Max1kNitsEQE { get; set; }
        [Required]
        public decimal MeanAt1kNitsEQE { get; set; }
        [Required]
        public decimal StdDevAt1kNitsEQE { get; set; }
        [Required]
        public decimal MaxAt1kNitsCE { get; set; }
        [Required]
        public decimal MeanAt1kNitsCE { get; set; }
        [Required]
        public decimal StdDevAt1kNitsCE { get; set; }
        [Required]
        public decimal ELPeakLambda { get; set; }
        [Required]
        public decimal ELFWHM { get; set; }
        public string StatsDataPath { get; set; }
        public string SpreadsheetReportPath { get; set; }  
        public string TestCondition { get; set; }
        public Nullable<decimal> MeanLuminanceAtMaxEQE { get; set; }

        public virtual Device Device { get; set; }
        public virtual ICollection<ELSpectrum> ELSpectrums { get; set; }
        public virtual ICollection<LJVScan> LJVScans { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }

}

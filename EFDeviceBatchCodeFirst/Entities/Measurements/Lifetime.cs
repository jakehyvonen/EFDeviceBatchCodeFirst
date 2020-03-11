using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDeviceBatchCodeFirst
{
    public partial class Lifetime
    {
        [Key]
        public int LifetimeId { get; set; }
        public decimal InitialLuminance { get; set; }
        [Required]
        public decimal SetCurrent { get; set; }
        public decimal InitialEQE { get; set; }
        public decimal TimeUntil97Percent { get; set; }
        public decimal TimeUntil90Percent { get; set; }
        public decimal TimeUntil50Percent { get; set; }
        public decimal InitialCE { get; set; }
        public string FilePath { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<decimal> SetCurrentDensity { get; set; }
        public Nullable<decimal> TotalHoursElapsed { get; set; }       
        public virtual Pixel Pixel { get; set; }
    }

}

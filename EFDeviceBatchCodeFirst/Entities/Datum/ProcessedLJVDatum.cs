using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDeviceBatchCodeFirst.Entities
{
    public class ProcessedLJVDatum
    {
        public decimal Voltage { get; set; }
        public decimal CurrentDensity { get; set; }
        public decimal PhotoCurrent { get; set; }
        public decimal Luminance { get; set; }
        public decimal CurrentEff { get; set; }
        public decimal PowerEff { get; set; }
        public decimal EQE { get; set; }
        public virtual LJVScan LJVScan { get; set; }
    }
}

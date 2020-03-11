using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDeviceBatchCodeFirst.Entities
{
    /// <summary>
    /// Contains all information for each datapoint from voltage sweeps
    /// </summary>
    public class FullLJVDatum
    {
        public decimal Voltage { get; set; }
        public decimal Current { get; set; }
        public decimal CurrentDensity { get; set; }
        public Nullable<decimal> Resistance { get; set; }
        public decimal PhotoCurrent { get; set; }
        public Nullable<decimal> CameraLuminance { get; set; }
        public Nullable<decimal> CameraCIEx { get; set; }
        public Nullable<decimal> CameraCIEy { get; set; }
        public decimal Luminance { get; set; }//calculated from Alpha*PhotoCurrent
        public decimal CurrentEff { get; set; }
        public decimal PowerEff { get; set; }
        public decimal EQE { get; set; }
        public string ELSpecPath { get; set; }
        public List<ELSpecDatum> ELSpecData { get; set; }
        public virtual LJVScan LJVScan { get; set; }
    }
}

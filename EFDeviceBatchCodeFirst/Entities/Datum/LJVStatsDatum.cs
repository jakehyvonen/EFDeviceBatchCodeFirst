using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDeviceBatchCodeFirst.Entities
{
    public class LJVStatsDatum
    {
        public decimal Voltage { get; set; }
        public decimal MeanCurrentDensity { get; set; }
        public decimal CurrentDensityStdDev { get; set; }
        public decimal MeanResistance { get; set; }
        public decimal ResistanceStdDev { get; set; }
        public decimal MeanPhotoCurrent { get; set; }
        public decimal PhotoCurrentStdDev { get; set; }
        public decimal MeanLuminance { get; set; }
        public decimal LuminanceStdDev { get; set; }
        public decimal MeanCurrentEff { get; set; }
        public decimal CurrentEffStdDev { get; set; }
        public decimal MeanPowerEff { get; set; }
        public decimal PowerEffStdDev { get; set; }
        public decimal MeanEQE { get; set; }
        public decimal EQEStdDev { get; set; }
        public Nullable<decimal> MeanCameraCIEx { get; set; }
        public Nullable<decimal> CameraCIExStdDev { get; set; }
        public Nullable<decimal> MeanCameraCIEy { get; set; }
        public Nullable<decimal> CameraCIEyStdDev { get; set; }
        public int PopulationSize { get; set; }
    }
}

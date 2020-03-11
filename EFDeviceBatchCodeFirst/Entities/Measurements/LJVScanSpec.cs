using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDeviceBatchCodeFirst
{
    public partial class LJVScanSpec
    {
       public LJVScanSpec()
        {

        }
        [Key]
        public int LJVScanSpecId { get; set; }
        public decimal StartVoltage { get; set; }
        public decimal StopVoltage { get; set; }  
        public decimal StepSize { get; set; }           //volts
        public decimal StopCurrent { get; set; }        //milliamps
        public decimal StopLuminance { get; set; }      //cd/m^2
        public decimal ActiveArea { get; set; } //m^2 (4E-6 for typical 2x2 mm pixel)
        public bool ShouldRecordSpectrumAtEachStep { get; set; }
        public int DeviceDwellTime { get; set; }        //milliseconds
        public string TestCondition { get; set; }      //t(test#).(daysSinceFabrication)
        public virtual LJVScan LJVScan { get; set; }
    }
}

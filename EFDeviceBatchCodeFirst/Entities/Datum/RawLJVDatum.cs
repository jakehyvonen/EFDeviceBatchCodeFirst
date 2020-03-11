using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDeviceBatchCodeFirst.Entities
{
    public class RawLJVDatum
    {
        public decimal Voltage { get; set; }
        public decimal PhotoCurrent1 { get; set; }
        public decimal Current { get; set; }
        public decimal PhotoCurrent2 { get; set; }
        public Nullable<decimal> CameraLuminance { get; set; }
        public Nullable<decimal> CameraCIEx { get; set; }
        public Nullable<decimal> CameraCIEy { get; set; }
        public decimal PhotoCurrent3 { get; set; }
        public virtual LJVScan LJVScan { get; set; }
    }
}

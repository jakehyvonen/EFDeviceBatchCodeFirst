using System;
using System.Collections.Generic;

namespace EFDeviceBatchCodeFirst
{
    public partial class QDBatch : Material
    {
        public QDBatch()
        {
            this.ELSpectrums = new HashSet<ELSpectrum>();
            this.Devices = new HashSet<Device>();
            this.PLSpectrums = new HashSet<PLSpectrum>();
        }

        public string Color { get; set; }
        public Nullable<decimal> PLPeakLambda { get; set; }
        public Nullable<decimal> PLFWHM { get; set; }

        public virtual ICollection<ELSpectrum> ELSpectrums { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<PLSpectrum> PLSpectrums { get; set; }
    }

}

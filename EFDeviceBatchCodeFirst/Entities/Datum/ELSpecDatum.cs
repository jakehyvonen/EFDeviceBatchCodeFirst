using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDeviceBatchCodeFirst.Entities
{
    public class ELSpecDatum
    {
        public double Wavelength { get; set; }//units = nm
        public double Intensity { get; set; }//units = W*m^-2*sr^-1*nm^-1
        public double Energy { get; set; }//units = eV
        public double JacobianIntensity { get; set; }//units = ??
        public virtual ELSpectrum ELSpectrum { get; set; }
    }
}

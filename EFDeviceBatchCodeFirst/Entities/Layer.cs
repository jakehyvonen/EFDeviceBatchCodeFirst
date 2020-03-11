using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDeviceBatchCodeFirst
{
    public partial class Layer
    {
        [Key]
        public int LayerId { get; set; }
        [Required]
        public int PositionIndex { get; set; }
        public Nullable<decimal> Thickness { get; set; }
        public Nullable<decimal> Roughness { get; set; }
      
        public Nullable<decimal> Transmittance { get; set; }
        public string Comment { get; set; }
        /*
        [ForeignKey("Solution")]
        public Nullable<int> SolutionId { get; set; }
        [ForeignKey("Device")]
        public Nullable<int> DeviceId { get; set; }
        [ForeignKey("Material")]
        public Nullable<int> MaterialId { get; set; }
        [ForeignKey("PhysicalRole")]
        public int PhysicalRoleId { get; set; }
        [ForeignKey("DepositionMethod")]
        public Nullable<int> DepositionMethodId { get; set; }
        */
        public string Pattern { get; set; }
        public Nullable<decimal> SheetResistance { get; set; }
        public Nullable<int> RPM { get; set; }
        public Nullable<int> SpinCoatDuration { get; set; }
        public Nullable<int> AnnealTemp { get; set; }
        public Nullable<int> AnnealDuration { get; set; }
        public Nullable<decimal> DepositionRate { get; set; }
        public Nullable<decimal> BackPressure { get; set; }
        public string CureCondition { get; set; }
        public Nullable<int> CureTime { get; set; }
        public string CoverGlassStyle { get; set; }
        public string AmbientEnvironment { get; set; }

        public Nullable<int> DispenseVolume { get; set; }
        public string SpreadSheetCellText { get; set; }

        public virtual PhysicalRole PhysicalRole { get; set; }
        public virtual DepositionMethod DepositionMethod { get; set; }
        public virtual Material Material { get; set; }
        public virtual Solution Solution { get; set; }
        public virtual Device Device { get; set; }
        public virtual LayerTemplate LayerTemplate { get; set; }
    }

}

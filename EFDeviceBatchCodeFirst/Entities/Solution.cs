using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDeviceBatchCodeFirst
{
    public partial class Solution
    {
        public Solution()
        {
            this.Layers = new HashSet<Layer>();
        }
        [Key]
        public int SolutionId { get; set; }
        public Nullable<decimal> InitialVolume { get; set; }
        public Nullable<decimal> Concentration { get; set; }
        public Nullable<System.DateTime> DatePreparedOrPurified { get; set; }
        /*
        [ForeignKey("Material")]
        public int MaterialId { get; set; }
        */
        public string Solvent { get; set; }
        public string Label { get; set; }

        public virtual Material Material { get; set; }
        public virtual ICollection<Layer> Layers { get; set; }
    }

}

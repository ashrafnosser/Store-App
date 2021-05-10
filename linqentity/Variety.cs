namespace linqentity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Variety
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code { get; set; }

        [StringLength(50)]
        public string vName { get; set; }

        [StringLength(50)]
        public string measruingUnit { get; set; }
        public int? quantity { get; set; }
        public string supplier { get; set; }
        public DateTime? productionDate { get; set; }
        public int? storeID { get; set; }
        public int? expire { get; set; }

        public virtual store store { get; set; }
    }
}

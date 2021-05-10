namespace linqentity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("transform")]
    public partial class transform
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int transformid { get; set; }

        [StringLength(50)]
        public string sfrom { get; set; }

        [StringLength(50)]
        public string sto { get; set; }

        public int? variety { get; set; }

        [StringLength(50)]
        public string supplier { get; set; }
        public int quantity { get; set; }
        public string varieties { get; set; }
        [Column(TypeName = "date")]
        public DateTime? production_history { get; set; }

        [StringLength(50)]
        public string Expiry { get; set; }
    }
}

namespace linqentity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Varieties_Dismissalpermessions
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dismissalId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Varieties { get; set; }

        public int? quantities { get; set; }

        public virtual DismissalPermission DismissalPermission { get; set; }
    }
}

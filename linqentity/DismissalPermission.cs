namespace linqentity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DismissalPermission")]
    public partial class DismissalPermission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DismissalPermission()
        {
            Varieties_Dismissalpermessions = new HashSet<Varieties_Dismissalpermessions>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dismissalId { get; set; }

        [StringLength(50)]
        public string Storename { get; set; }

        [Column(TypeName = "date")]
        public DateTime? history { get; set; }

        [StringLength(50)]
        public string supplieName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ptoductionHistory { get; set; }

        [StringLength(50)]
        public string expiry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Varieties_Dismissalpermessions> Varieties_Dismissalpermessions { get; set; }
    }
}

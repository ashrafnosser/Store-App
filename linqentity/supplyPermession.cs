namespace linqentity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("supplyPermession")]
    public partial class supplyPermession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public supplyPermession()
        {
            Varieties_supplypermessions = new HashSet<Varieties_supplypermessions>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SuplyId { get; set; }

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
        public virtual ICollection<Varieties_supplypermessions> Varieties_supplypermessions { get; set; }
    }
}

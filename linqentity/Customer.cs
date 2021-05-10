namespace linqentity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customerId { get; set; }
        public string Name { get; set; }
        [StringLength(50)]
        public string telephone { get; set; }

        [StringLength(50)]
        public string fax { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string website { get; set; }
    }
}

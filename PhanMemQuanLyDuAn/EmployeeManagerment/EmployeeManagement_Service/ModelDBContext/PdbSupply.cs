namespace EmployeeManagement_Service.ModelDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PdbSupply
    {
        [Key]
        public Guid IDSupplies { get; set; }

        public Guid IDStaff { get; set; }

        [Required]
        [StringLength(50)]
        public string NameSupplies { get; set; }

        [Required]
        [StringLength(50)]
        public string ReasonBorrow { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateBorrow { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateReturn { get; set; }

        [Required]
        [StringLength(50)]
        public string StatusBefore { get; set; }

        [Required]
        [StringLength(50)]
        public string StatusAfter { get; set; }

        public bool isReturn { get; set; }

        public virtual PdbStaff PdbStaff { get; set; }
    }
}

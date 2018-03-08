namespace EmployeeManagement_Service.ModelDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PdbContract")]
    public partial class PdbContract
    {
        [Key]
        public Guid IDContract { get; set; }

        public Guid IDStaff { get; set; }

        [Required]
        [StringLength(20)]
        public string ContractType { get; set; }

        [StringLength(50)]
        public string ContractDescription { get; set; }

        [StringLength(20)]
        public string PayForms { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EndDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? SignDate { get; set; }

        public virtual PdbStaff PdbStaff { get; set; }
    }
}

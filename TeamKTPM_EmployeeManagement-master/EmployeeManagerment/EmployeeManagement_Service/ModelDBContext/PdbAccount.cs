namespace EmployeeManagement_Service.ModelDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PdbAccount")]
    public partial class PdbAccount
    {
        [Key]
        public Guid IDAccount { get; set; }

        public Guid IDStaff { get; set; }

        [Required]
        [StringLength(20)]
        public string AccountName { get; set; }

        [Required]
        [StringLength(20)]
        public string AccountPassword { get; set; }

        [Required]
        [StringLength(20)]
        public string AccountLevel { get; set; }

        public bool isActive { get; set; }

        public virtual PdbStaff PdbStaff { get; set; }
    }
}

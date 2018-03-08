namespace EmployeeManagement_Service.ModelDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PdbEducationLevel")]
    public partial class PdbEducationLevel
    {
        [Key]
        public Guid ID_EL { get; set; }

        public Guid IDStaff { get; set; }

        [Required]
        [StringLength(50)]
        public string NameEL { get; set; }

        [Required]
        [StringLength(40)]
        public string Major { get; set; }

        [Required]
        [StringLength(20)]
        public string CertificateType { get; set; }

        [Required]
        [StringLength(50)]
        public string PlaceProvide { get; set; }

        [Required]
        [StringLength(20)]
        public string Result { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateOut { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateProvide { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        public virtual PdbStaff PdbStaff { get; set; }
    }
}

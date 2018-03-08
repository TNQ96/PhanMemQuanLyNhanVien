namespace EmployeeManagement_Service.ModelDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PdbStaff")]
    public partial class PdbStaff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PdbStaff()
        {
            PdbAccounts = new HashSet<PdbAccount>();
            PdbBonusSalaries = new HashSet<PdbBonusSalary>();
            PdbContracts = new HashSet<PdbContract>();
            PdbEducationLevels = new HashSet<PdbEducationLevel>();
            PdbStaffEvents = new HashSet<PdbStaffEvent>();
            PdbSupplies = new HashSet<PdbSupply>();
        }

        [Key]
        public Guid ID_Staff { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(10)]
        public string IndentityCard { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Date_Create_IC { get; set; }

        [Required]
        [StringLength(50)]
        public string Place_Create_IC { get; set; }

        [Required]
        [StringLength(50)]
        public string Hometown { get; set; }

        [Required]
        [StringLength(15)]
        public string Phone { get; set; }

        [Required]
        [StringLength(20)]
        public string AddressNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string AddressStreet { get; set; }

        [Required]
        [StringLength(20)]
        public string AddressWard { get; set; }

        [StringLength(30)]
        public string AddressDistrict { get; set; }

        [Required]
        [StringLength(30)]
        public string AddressCity { get; set; }

        [Required]
        [StringLength(5)]
        public string Sex { get; set; }

        [Required]
        [StringLength(30)]
        public string Department { get; set; }

        [Required]
        [StringLength(30)]
        public string Position { get; set; }

        [Column(TypeName = "money")]
        public decimal SalaryBasic { get; set; }

        public double CoefficientsSalary { get; set; }

        public bool isMarried { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateStartWork { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateEndWork { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] Image { get; set; }

        [Required]
        [StringLength(500)]
        public string Produce { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdbAccount> PdbAccounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdbBonusSalary> PdbBonusSalaries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdbContract> PdbContracts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdbEducationLevel> PdbEducationLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdbStaffEvent> PdbStaffEvents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdbSupply> PdbSupplies { get; set; }
    }
}

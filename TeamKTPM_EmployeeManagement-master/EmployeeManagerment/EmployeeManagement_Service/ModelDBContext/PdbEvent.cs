namespace EmployeeManagement_Service.ModelDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PdbEvent")]
    public partial class PdbEvent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PdbEvent()
        {
            PdbStaffEvents = new HashSet<PdbStaffEvent>();
        }

        [Key]
        public Guid ID_Event { get; set; }

        [Required]
        [StringLength(50)]
        public string EventName { get; set; }

        [Column(TypeName = "money")]
        public decimal ExpectedCost { get; set; }

        [Column(TypeName = "money")]
        public decimal CostsAwarded { get; set; }

        [Column(TypeName = "money")]
        public decimal ActualCosts { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateStart { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateEnd { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        [Required]
        [StringLength(50)]
        public string Scale { get; set; }

        [Required]
        [StringLength(500)]
        public string EventContent { get; set; }

        [Required]
        [StringLength(50)]
        public string TravelBy { get; set; }

        [Column(TypeName = "money")]
        public decimal? Money_Staff_Pay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PdbStaffEvent> PdbStaffEvents { get; set; }
    }
}

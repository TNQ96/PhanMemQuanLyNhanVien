namespace EmployeeManagement_Service.ModelDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PdbBonusSalary")]
    public partial class PdbBonusSalary
    {
        [Key]
        public Guid IDBS { get; set; }

        public Guid IDStaff { get; set; }

        [Column(TypeName = "money")]
        public decimal MoneyBonus { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DayBonus { get; set; }

        [Required]
        [StringLength(100)]
        public string ReasonBonus { get; set; }

        [Required]
        [StringLength(3)]
        public string MonthBonus { get; set; }

        [Required]
        [StringLength(5)]
        public string YearBonus { get; set; }

        public virtual PdbStaff PdbStaff { get; set; }
    }
}

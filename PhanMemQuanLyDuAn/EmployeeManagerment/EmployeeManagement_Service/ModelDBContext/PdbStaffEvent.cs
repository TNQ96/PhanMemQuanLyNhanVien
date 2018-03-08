namespace EmployeeManagement_Service.ModelDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PdbStaffEvent")]
    public partial class PdbStaffEvent
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID_StaffEvent { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ID_Staff { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ID_Event { get; set; }

        public bool isStatus { get; set; }

        public bool? isPaidByStaff { get; set; }

        public virtual PdbEvent PdbEvent { get; set; }

        public virtual PdbStaff PdbStaff { get; set; }
    }
}

namespace EmployeeManagement_Service.ModelDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PdbFeedBack")]
    public partial class PdbFeedBack
    {
        [Key]
        public Guid IDFeedBack { get; set; }

        [StringLength(8)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Point { get; set; }

        [Required]
        [StringLength(50)]
        public string Favourite_Software_Interface { get; set; }

        [Required]
        [StringLength(50)]
        public string Favourite_Managerial_Funtion { get; set; }

        [Required]
        [StringLength(50)]
        public string Worst_Software_Interface { get; set; }

        [Required]
        [StringLength(50)]
        public string Worst_Managerial_Funtion { get; set; }

        [StringLength(500)]
        public string UserShare { get; set; }
    }
}

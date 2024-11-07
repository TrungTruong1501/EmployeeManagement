namespace EmployeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_INSURANCE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InsuranceID { get; set; }

        [StringLength(50)]
        public string InsuranceNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IssueDate { get; set; }

        [StringLength(50)]
        public string PlaceOfIssue { get; set; }

        [StringLength(50)]
        public string MedicalFacility { get; set; }

        public int? EmployeeID { get; set; }

        public virtual tb_EMPLOYEE tb_EMPLOYEE { get; set; }
    }
}

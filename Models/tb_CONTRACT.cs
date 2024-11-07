namespace EmployeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_CONTRACT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContractNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SigningDate { get; set; }

        public int? RenewalCount { get; set; }

        [StringLength(50)]
        public string Duration { get; set; }

        public double? SalaryCoefficient { get; set; }

        public int? EmployeeID { get; set; }

        public virtual tb_EMPLOYEE tb_EMPLOYEE { get; set; }
    }
}

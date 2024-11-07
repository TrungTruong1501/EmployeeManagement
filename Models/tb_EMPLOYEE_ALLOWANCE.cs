namespace EmployeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_EMPLOYEE_ALLOWANCE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? EmployeeID { get; set; }

        public int? AllowanceID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [StringLength(255)]
        public string Content { get; set; }

        public double? Amount { get; set; }

        public virtual tb_ALLOWANCE tb_ALLOWANCE { get; set; }

        public virtual tb_EMPLOYEE tb_EMPLOYEE { get; set; }
    }
}

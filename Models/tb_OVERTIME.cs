namespace EmployeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_OVERTIME
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public double? Hours { get; set; }

        public int? EmployeeID { get; set; }

        public int? ShiftID { get; set; }

        public virtual tb_EMPLOYEE tb_EMPLOYEE { get; set; }

        public virtual tb_SHIFT tb_SHIFT { get; set; }
    }
}

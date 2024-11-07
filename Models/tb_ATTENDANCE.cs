namespace EmployeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_ATTENDANCE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AttendanceID { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public TimeSpan? CheckInTime { get; set; }

        public TimeSpan? CheckOutTime { get; set; }

        public int? MinutesLate { get; set; }

        public int? MinutesEarly { get; set; }

        public int? EmployeeID { get; set; }

        public int? WorkTypeID { get; set; }

        public virtual tb_EMPLOYEE tb_EMPLOYEE { get; set; }

        public virtual tb_WORKTYPE tb_WORKTYPE { get; set; }
    }
}

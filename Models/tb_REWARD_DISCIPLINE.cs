namespace EmployeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_REWARD_DISCIPLINE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? RewardDisciplineNumber { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? Type { get; set; }

        public int? EmployeeID { get; set; }

        public virtual tb_EMPLOYEE tb_EMPLOYEE { get; set; }
    }
}

namespace EmployeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_ACCOUNT
    {
        [Key]
        public int AccountID { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(255)]
        public string Password { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Role { get; set; }

        public int? EmployeeID { get; set; }

        public virtual tb_EMPLOYEE tb_EMPLOYEE { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EmployeeManagement.Models
{
    public partial class Manage : DbContext
    {
        public Manage()
            : base("name=Manage")
        {
        }

        public virtual DbSet<tb_ACCOUNT> tb_ACCOUNT { get; set; }
        public virtual DbSet<tb_ALLOWANCE> tb_ALLOWANCE { get; set; }
        public virtual DbSet<tb_ATTENDANCE> tb_ATTENDANCE { get; set; }
        public virtual DbSet<tb_CONTRACT> tb_CONTRACT { get; set; }
        public virtual DbSet<tb_DEPARTMENT> tb_DEPARTMENT { get; set; }
        public virtual DbSet<tb_DIVISION> tb_DIVISION { get; set; }
        public virtual DbSet<tb_EDUCATION> tb_EDUCATION { get; set; }
        public virtual DbSet<tb_EMPLOYEE> tb_EMPLOYEE { get; set; }
        public virtual DbSet<tb_EMPLOYEE_ALLOWANCE> tb_EMPLOYEE_ALLOWANCE { get; set; }
        public virtual DbSet<tb_INSURANCE> tb_INSURANCE { get; set; }
        public virtual DbSet<tb_OVERTIME> tb_OVERTIME { get; set; }
        public virtual DbSet<tb_POSITION> tb_POSITION { get; set; }
        public virtual DbSet<tb_REWARD_DISCIPLINE> tb_REWARD_DISCIPLINE { get; set; }
        public virtual DbSet<tb_SALARY_ADVANCE> tb_SALARY_ADVANCE { get; set; }
        public virtual DbSet<tb_SHIFT> tb_SHIFT { get; set; }
        public virtual DbSet<tb_WORKTYPE> tb_WORKTYPE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

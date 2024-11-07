namespace EmployeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_ALLOWANCE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_ALLOWANCE()
        {
            tb_EMPLOYEE_ALLOWANCE = new HashSet<tb_EMPLOYEE_ALLOWANCE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AllowanceID { get; set; }

        [StringLength(50)]
        public string AllowanceName { get; set; }

        public double? Amount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_EMPLOYEE_ALLOWANCE> tb_EMPLOYEE_ALLOWANCE { get; set; }
    }
}

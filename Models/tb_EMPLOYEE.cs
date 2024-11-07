namespace EmployeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_EMPLOYEE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_EMPLOYEE()
        {
            tb_ACCOUNT = new HashSet<tb_ACCOUNT>();
            tb_ATTENDANCE = new HashSet<tb_ATTENDANCE>();
            tb_CONTRACT = new HashSet<tb_CONTRACT>();
            tb_EMPLOYEE_ALLOWANCE = new HashSet<tb_EMPLOYEE_ALLOWANCE>();
            tb_INSURANCE = new HashSet<tb_INSURANCE>();
            tb_OVERTIME = new HashSet<tb_OVERTIME>();
            tb_REWARD_DISCIPLINE = new HashSet<tb_REWARD_DISCIPLINE>();
            tb_SALARY_ADVANCE = new HashSet<tb_SALARY_ADVANCE>();
        }
        public tb_EMPLOYEE(int employeeID, string fullName, string gender, DateTime? dateOfBirth, string phoneNumber, string identityCard, string address, int? departmentID, int? divisionID, int? positionID, int? educationID, byte[] profilePicture)
        {
            EmployeeID = employeeID;
            FullName = fullName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            IdentityCard = identityCard;
            Address = address;
            ProfilePicture = profilePicture;
            DepartmentID = departmentID;
            DivisionID = divisionID;
            PositionID = positionID;
            EducationID = educationID;
            
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(20)]
        public string IdentityCard { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(255)]
        public byte[] ProfilePicture { get; set; }

        public int? DepartmentID { get; set; }

        public int? DivisionID { get; set; }

        public int? PositionID { get; set; }

        public int? EducationID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ACCOUNT> tb_ACCOUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ATTENDANCE> tb_ATTENDANCE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_CONTRACT> tb_CONTRACT { get; set; }

        public virtual tb_DEPARTMENT tb_DEPARTMENT { get; set; }

        public virtual tb_DIVISION tb_DIVISION { get; set; }

        public virtual tb_EDUCATION tb_EDUCATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_EMPLOYEE_ALLOWANCE> tb_EMPLOYEE_ALLOWANCE { get; set; }

        public virtual tb_POSITION tb_POSITION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_INSURANCE> tb_INSURANCE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_OVERTIME> tb_OVERTIME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_REWARD_DISCIPLINE> tb_REWARD_DISCIPLINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_SALARY_ADVANCE> tb_SALARY_ADVANCE { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HRBusinessObjects
{
    [Table("employees")]
    public partial class Employee
    {
        public Employee()
        {
            Dependents = new HashSet<Dependent>();
            InverseManager = new HashSet<Employee>();
        }

        [Key]
        [Column("employee_id")]
        public int EmployeeId { get; set; }
        [Column("first_name")]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name")]
        [StringLength(25)]
        public string LastName { get; set; }
        [Required]
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column("phone_number")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Column("hire_date", TypeName = "date")]
        public DateTime HireDate { get; set; }
        [Column("job_id")]
        public int JobId { get; set; }
        [Column("salary", TypeName = "decimal(8, 2)")]
        public decimal Salary { get; set; }
        [Column("manager_id")]
        public int? ManagerId { get; set; }
        [Column("department_id")]
        public int? DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty("Employees")]
        public virtual Department Department { get; set; }
        [ForeignKey(nameof(JobId))]
        [InverseProperty("Employees")]
        public virtual Job Job { get; set; }
        [ForeignKey(nameof(ManagerId))]
        [InverseProperty(nameof(Employee.InverseManager))]
        public virtual Employee Manager { get; set; }
        [InverseProperty(nameof(Dependent.Employee))]
        public virtual ICollection<Dependent> Dependents { get; set; }
        [InverseProperty(nameof(Employee.Manager))]
        public virtual ICollection<Employee> InverseManager { get; set; }
    }
}

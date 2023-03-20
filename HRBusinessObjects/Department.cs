using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HRBusinessObjects
{
    [Table("departments")]
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        [Column("department_id")]
        public int DepartmentId { get; set; }
        [Required]
        [Column("department_name")]
        [StringLength(30)]
        public string DepartmentName { get; set; }
        [Column("location_id")]
        public int? LocationId { get; set; }

        [ForeignKey(nameof(LocationId))]
        [InverseProperty("Departments")]
        public virtual Location Location { get; set; }
        [InverseProperty(nameof(Employee.Department))]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}

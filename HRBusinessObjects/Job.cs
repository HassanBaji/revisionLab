using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HRBusinessObjects
{
    [Table("jobs")]
    public partial class Job
    {
        public Job()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        [Column("job_id")]
        public int JobId { get; set; }
        [Required]
        [Column("job_title")]
        [StringLength(35)]
        public string JobTitle { get; set; }
        [Column("min_salary", TypeName = "decimal(8, 2)")]
        public decimal? MinSalary { get; set; }
        [Column("max_salary", TypeName = "decimal(8, 2)")]
        public decimal? MaxSalary { get; set; }

        [InverseProperty(nameof(Employee.Job))]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}

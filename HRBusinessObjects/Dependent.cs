using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HRBusinessObjects
{
    [Table("dependents")]
    public partial class Dependent
    {
        [Key]
        [Column("dependent_id")]
        public int DependentId { get; set; }
        [Required]
        [Column("first_name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Column("relationship")]
        [StringLength(25)]
        public string Relationship { get; set; }
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Dependents")]
        public virtual Employee Employee { get; set; }
    }
}

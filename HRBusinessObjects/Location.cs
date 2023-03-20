using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HRBusinessObjects
{
    [Table("locations")]
    public partial class Location
    {
        public Location()
        {
            Departments = new HashSet<Department>();
        }

        [Key]
        [Column("location_id")]
        public int LocationId { get; set; }
        [Column("street_address")]
        [StringLength(40)]
        public string StreetAddress { get; set; }
        [Column("postal_code")]
        [StringLength(12)]
        public string PostalCode { get; set; }
        [Required]
        [Column("city")]
        [StringLength(30)]
        public string City { get; set; }
        [Column("state_province")]
        [StringLength(25)]
        public string StateProvince { get; set; }
        [Required]
        [Column("country_id")]
        [StringLength(2)]
        public string CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("Locations")]
        public virtual Country Country { get; set; }
        [InverseProperty(nameof(Department.Location))]
        public virtual ICollection<Department> Departments { get; set; }
    }
}

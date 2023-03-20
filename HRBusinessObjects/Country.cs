using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HRBusinessObjects
{
    [Table("countries")]
    public partial class Country
    {
        public Country()
        {
            Locations = new HashSet<Location>();
        }

        [Key]
        [Column("country_id")]
        [StringLength(2)]
        public string CountryId { get; set; }
        [Column("country_name")]
        [StringLength(40)]
        public string CountryName { get; set; }
        [Column("region_id")]
        public int RegionId { get; set; }

        [ForeignKey(nameof(RegionId))]
        [InverseProperty("Countries")]
        public virtual Region Region { get; set; }
        [InverseProperty(nameof(Location.Country))]
        public virtual ICollection<Location> Locations { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HRBusinessObjects
{
    [Table("regions")]
    public partial class Region
    {
        public Region()
        {
            Countries = new HashSet<Country>();
        }

        [Key]
        [Column("region_id")]
        public int RegionId { get; set; }
        [Column("region_name")]
        [StringLength(25)]
        public string RegionName { get; set; }

        [InverseProperty(nameof(Country.Region))]
        public virtual ICollection<Country> Countries { get; set; }
    }
}

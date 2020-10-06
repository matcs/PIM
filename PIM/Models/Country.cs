using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models
{
    public class Country
    {
        [Key]
        public long CountryId { get; set; }
        [Column(TypeName = "VARCHAR(35)")]
        public string CountryName { get; set; }

        [ForeignKey("Address")]
        public long AddressId { get; set; }

        public Country() { }

        public Country(long countryId, string countryName, long addressId)
        {
            CountryId = countryId;
            CountryName = countryName;
            AddressId = addressId;
        }
    }
}

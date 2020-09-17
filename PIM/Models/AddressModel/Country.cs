using PIM.Models.PersonModel;
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
        public String CountryName { get; set; }
        public Address Address { get; set; }

        public Country() { }

        public Country(long countryId, string countryName, Address address)
        {
            CountryId = countryId;
            CountryName = countryName;
            Address = address;
        }
    }
}

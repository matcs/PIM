using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM.Models
{
    public class Country
    {
        [Key]
        public long CountryId { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(35)")]
        public string CountryName { get; set; }

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

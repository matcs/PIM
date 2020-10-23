using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM.Models
{
    public class Address
    {
        [Key]
        public long AddressId { get; set; }

        //Logradouro
        [Required]
        [Column(TypeName = "VARCHAR(25)")]
        public string PublicArea { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(10)")]
        public string StreetNumber { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(40)")]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(40)")]
        public string Neighborhood { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(25)")]
        public string ZipCode { get; set; }

        public string UserId { get; set; }

        public Address() { }

        public Address(long addressId)
        {
            AddressId = addressId;
        }

        public Address(long addressId, string publicArea, string streetNumber, string city, string neighborhood, string zipCode, string userId) : this(addressId)
        {
            PublicArea = publicArea;
            StreetNumber = streetNumber;
            City = city;
            Neighborhood = neighborhood;
            ZipCode = zipCode;
            UserId = userId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models
{
    public class Address
    {
        [Key]
        public long AddressId { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string AddrType { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string AddrNumber { get; set; }
        [Column(TypeName = "VARCHAR(40)")]
        public string AddrCity { get; set; }
        [Column(TypeName = "VARCHAR(40)")]
        public string AddrNeighbohood { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string ZipCode { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }

        public Address() { }

        public Address(long addressId)
        {
            AddressId = addressId;
        }

        public Address(long addressId, string addrType, string addrNumber, string addrCity, string addrNeighbohood, string zipCode, long userId) : this(addressId)
        {
            AddrType = addrType;
            AddrNumber = addrNumber;
            AddrCity = addrCity;
            AddrNeighbohood = addrNeighbohood;
            ZipCode = zipCode;
            UserId = userId;
        }
    }
}

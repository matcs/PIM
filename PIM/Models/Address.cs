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
        public String AddrType { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public String AddrNumber { get; set; }
        [Column(TypeName = "VARCHAR(40)")]
        public String AddrCity { get; set; }
        [Column(TypeName = "VARCHAR(40)")]
        public String AddrNeighbohood { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public String ZipCode { get; set; }

        [ForeignKey("Person")]
        public long PersonId { get; set; }

        public Address() { }

        public Address(long addressId)
        {
            AddressId = addressId;
        }

        public Address(long addressId, string addrType, string addrNumber, string addrCity, string addrNeighbohood, string zipCode, long personId) : this(addressId)
        {
            AddrType = addrType;
            AddrNumber = addrNumber;
            AddrCity = addrCity;
            AddrNeighbohood = addrNeighbohood;
            ZipCode = zipCode;
            PersonId = personId;
        }
    }
}

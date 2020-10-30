using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class AddressViewModel
    {
        public long AddressId { get; set; }

        //Logradouro
        public string PublicArea { get; set; }

        public string StreetNumber { get; set; }

        public string City { get; set; }

        public string Neighborhood { get; set; }

        public string ZipCode { get; set; }

        public string UserId { get; set; }

        public AddressViewModel() { }

        public AddressViewModel(long addressId, string publicArea, string streetNumber, string city, string neighborhood, string zipCode, string userId)
        {
            AddressId = addressId;
            PublicArea = publicArea;
            StreetNumber = streetNumber;
            City = city;
            Neighborhood = neighborhood;
            ZipCode = zipCode;
            UserId = userId;
        }
    }
}

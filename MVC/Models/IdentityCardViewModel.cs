using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class IdentityCardViewModel
    {
        public string IdentityCardId { get; set; }

        //RG
        public string Identification { get; set; }

        //CPF
        public string IndividualTaxpayerRegistration { get; set; }

        //Órgão emissor
        public string IssuingBody { get; set; }

        //Data de expedição
        public DateTime ShippingDate { get; set; }

        public IdentityCardViewModel() { }

        public IdentityCardViewModel(string identityCardId, string identification, string individualTaxpayerRegistration, string issuingBody, DateTime shippingDate)
        {
            IdentityCardId = identityCardId;
            Identification = identification;
            IndividualTaxpayerRegistration = individualTaxpayerRegistration;
            IssuingBody = issuingBody;
            ShippingDate = shippingDate;
        }
    }
}

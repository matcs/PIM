using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM.Models
{
    public class IdentityCard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "NVARCHAR(40)")]
        public string IdentityCardId { get; set; }

        //RG
        [Column(TypeName = "NVARCHAR(10)")]
        public string Identification { get; set; }

        //CPF       
        [Column(TypeName = "NVARCHAR(12)")]
        [Index(IsUnique = true)]
        public string IndividualTaxpayerRegistration { get; set; }

        //Órgão emissor
        public string IssuingBody { get; set; }

        //Data de expedição
        public DateTime ShippingDate { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }

        public IdentityCard() { }

        public IdentityCard(string identityCardId, string identification, string individualTaxpayerRegistration, string issuingBody, DateTime shippingDate, long userId)
        {
            IdentityCardId = identityCardId;
            Identification = identification;
            IndividualTaxpayerRegistration = individualTaxpayerRegistration;
            IssuingBody = issuingBody;
            ShippingDate = shippingDate;
            UserId = userId;
        }
    }
}

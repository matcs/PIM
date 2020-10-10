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
        [Required]
        [Column(TypeName = "NVARCHAR(10)")]
        public string Identification { get; set; }

        //CPF
        [Required]
        [Column(TypeName = "NVARCHAR(12)")]
        [Index(IsUnique = true)]
        public string IndividualTaxpayerRegistration { get; set; }

        //Órgão emissor
        [Required]
        [Column(TypeName = "VARCHAR(5)")]
        public string IssuingBody { get; set; }

        //Data de expedição
        [Required]
        public DateTime ShippingDate { get; set; }

        public User User { get; set; }

        public IdentityCard() { }

        public IdentityCard(string identityCardId, string identification, string individualTaxpayerRegistration, string issuingBody, DateTime shippingDate, User user)
        {
            IdentityCardId = identityCardId;
            Identification = identification;
            IndividualTaxpayerRegistration = individualTaxpayerRegistration;
            IssuingBody = issuingBody;
            ShippingDate = shippingDate;
            User = user;
        }
    }
}

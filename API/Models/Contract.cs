using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Contract
    {
        [Key]
        public long ContractId { get; set; }

        [Required]
        [Column(TypeName = "VARBINARY(MAX)")]
        public string ContractTerms { get; set; }

        [ForeignKey("Customer")]
        public string CustomerId { get; set; }

        public Customer Customer { get; set; }

        public Contract() { }

        public Contract(long contractId, string contractTerms)
        {
            ContractId = contractId;
            ContractTerms = contractTerms;
        }
    }
}

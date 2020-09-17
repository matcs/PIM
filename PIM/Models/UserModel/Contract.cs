using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models.User
{
    public class Contract
    {
        [Key]
        public long ContractId { get; set; }
        [Column(TypeName = "VARBINARY(MAX)")]
        public String ContractTerms { get; set; }

        public Contract()
        {
        }

        public Contract(long contractId, string contractTerms)
        {
            ContractId = contractId;
            ContractTerms = contractTerms;
        }
    }
}

﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM.Models
{
    public class Contract
    {
        [Key]
        public long ContractId { get; set; }
        [Column(TypeName = "VARBINARY(MAX)")]
        public string ContractTerms { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }

        public Contract() { }

        public Contract(long contractId, string contractTerms, long userId)
        {
            ContractId = contractId;
            ContractTerms = contractTerms;
            UserId = userId;
        }
    }
}

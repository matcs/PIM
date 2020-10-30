using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class ContractViewModel
    {
        public long ContractId { get; set; }

        public string ContractTerms { get; set; }

        public string CustomerId { get; set; }

        public ContractViewModel() { }

        public ContractViewModel(long contractId, string contractTerms, string customerId)
        {
            ContractId = contractId;
            ContractTerms = contractTerms;
            CustomerId = customerId;
        }
    }
}

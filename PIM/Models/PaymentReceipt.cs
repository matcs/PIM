using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace PIM.Models
{
    public class PaymentReceipt
    {
        [Key]
        public string PaymentReceiptsId { get; set; }

        public DateTime TransactionDate { get; set; }

        public double Amount { get; set; }

        public string Description { get; set; }

        public PaymentReceipt() { }

        public PaymentReceipt(string paymentReceiptsId, DateTime transactionDate, double amount, string description)
        {
            PaymentReceiptsId = paymentReceiptsId;
            TransactionDate = transactionDate;
            Amount = amount;
            Description = description;
        }
    }
}

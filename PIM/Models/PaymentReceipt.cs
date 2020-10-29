using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM.Models
{
    public class PaymentReceipt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "NVARCHAR(40)")]
        public string PaymentReceiptsId { get; set; }

        public DateTime TransactionDate { get; set; }

        [Required]
        [Column(TypeName = "FLOAT")]
        public double Amount { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(200)")]
        public string Description { get; set; }

        [ForeignKey("Customer")]
        public string CustomerId { get; set; }

        public Customer Customer { get; set; }

        public PaymentReceipt() { }

        public PaymentReceipt(string paymentReceiptsId, DateTime transactionDate, double amount, string description, Customer customerId)
        {
            PaymentReceiptsId = paymentReceiptsId;
            TransactionDate = transactionDate;
            Amount = amount;
            Description = description;
            Customer = customerId;
        }

        public override string ToString()
        {
            return PaymentReceiptsId + ", " + TransactionDate + ", " + Amount + ", " + Description;
        }
    }
}

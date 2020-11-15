using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "NVARCHAR(40)")]
        public string CustomerId { get; set; }

        [Required]
        public bool AccountStatus { get; set; }

        public int TotalOfPayments { get; set; }

        public List<PaymentReceipt> PaymentReceipts { get; set; }

        public List<Contract> Contracts { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public User User { get; set; }

        public Customer() { }

        public Customer(string custumersId, bool accountStatus, int totalOfPayments, List<PaymentReceipt> paymentReceipts, List<Contract> contracts, User user)
        {
            CustomerId = custumersId;
            AccountStatus = accountStatus;
            TotalOfPayments = totalOfPayments;
            PaymentReceipts = paymentReceipts;
            Contracts = contracts;
            User = user;
        }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM.Models
{
    public class Customer
    {
        [Key]
        public long CustumersId { get; set; }
        public bool AccountStatus { get; set; }
        public List<PaymentReceipt> PaymentReceipts { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }

        public Customer() { }

        public Customer(long custumersId, bool accountStatus, List<PaymentReceipt> paymentReceipts, long userId)
        {
            CustumersId = custumersId;
            AccountStatus = accountStatus;
            PaymentReceipts = paymentReceipts;
            UserId = userId;
        }
    }
}

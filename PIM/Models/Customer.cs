using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models
{
    public class Customer
    {
        [Key]
        public long CustumersId { get; set; }
        public bool AccountStatus { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }

        public Customer() { }

        public Customer(long custumersId, bool accountStatus, long userId)
        {
            CustumersId = custumersId;
            AccountStatus = accountStatus;
            UserId = userId;
        }
    }
}

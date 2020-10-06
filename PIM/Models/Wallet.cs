using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models
{
    public class Wallet
    {
        [Key]
        public long WalletId { get; set; }
        public double WalletBalance { get; set; }

        [ForeignKey("Customers")]
        public long CustomersId { get; set; }

        public Wallet() { }

        public Wallet(long walletId, double walletBalance, long customersId)
        {
            WalletId = walletId;
            WalletBalance = walletBalance;
            CustomersId = customersId;
        }
    }
}

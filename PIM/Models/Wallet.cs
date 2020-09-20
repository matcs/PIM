using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models.User
{
    public class Wallet
    {
        [Key]
        public long WalletId { get; set; }
        public double WalletBalance { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }

        public Wallet() { }

        public Wallet(long walletId, double walletBalance, long userId)
        {
            WalletId = walletId;
            WalletBalance = walletBalance;
            UserId = userId;
        }
    }
}

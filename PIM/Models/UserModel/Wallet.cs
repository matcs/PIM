using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models.User
{
    public class Wallet
    {
        [Key]
        public long WalletId { get; set; }
        public double WalletBalance { get; set; }
        
        public User User { get; set; }

        public Wallet() { }

        public Wallet(long walletId, double walletBalance, User user)
        {
            WalletId = walletId;
            WalletBalance = walletBalance;
            User = user;
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace PIM.Models
{
    public class Wallet
    {
        [Key]
        public long WalletId { get; set; }
        public double WalletBalance { get; set; }

        public Customer Customer { get; set; }

        public Wallet() { }

        public Wallet(long walletId, double walletBalance, Customer customer)
        {
            WalletId = walletId;
            WalletBalance = walletBalance;
            Customer = customer;
        }
    }
}

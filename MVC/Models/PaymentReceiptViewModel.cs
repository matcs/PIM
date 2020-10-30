using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class PaymentReceiptViewModel
    {
        public string PaymentReceiptsId { get; set; }

        public DateTime TransactionDate { get; set; }

        public double Amount { get; set; }

        public string Description { get; set; }


    }
}

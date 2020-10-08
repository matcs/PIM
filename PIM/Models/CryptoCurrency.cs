using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models
{
    public class CryptoCurrency
    {
        public long CryptoCurrencyId { get; set; }

        public double Value { get; set; }

        public DateTime ValueDate { get; set; }

        public CryptoCurrency() { }

        public CryptoCurrency(long cryptoCurrencyId, double value, DateTime valueDate)
        {
            CryptoCurrencyId = cryptoCurrencyId;
            Value = value;
            ValueDate = valueDate;
        }
    }
}

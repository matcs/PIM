using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class CryptoCurrency
    {
        [Key]
        public long CryptoCurrencyId { get; set; }

        [Required]
        [Column(TypeName = "FLOAT")]
        public double Value { get; set; }

        [Required]
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

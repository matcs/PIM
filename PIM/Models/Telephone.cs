using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM.Models
{
    public class Telephone
    {
        [Key]
        public long TelephoneId { get; set; }
        [Column(TypeName = "VARCHAR(5)")]
        public string DDD { get; set; }
        [Column(TypeName = "VARCHAR(11)")]
        public String TelephoneNumber { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }

        public Telephone() { }

        public Telephone(long telephoneId, string dDD, string telephoneNumber, long userId)
        {
            TelephoneId = telephoneId;
            DDD = dDD;
            TelephoneNumber = telephoneNumber;
            UserId = userId;
        }
    }
}

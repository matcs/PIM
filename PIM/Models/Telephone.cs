using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM.Models
{
    public class Telephone
    {
        [Key]
        public long TelephoneId { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(5)")]
        public string DDD { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(11)")]
        public string PhoneNumber { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public User User { get; set; }

        public Telephone() { }

        public Telephone(long telephoneId, string dDD, string phoneNumber)
        {
            TelephoneId = telephoneId;
            DDD = dDD;
            PhoneNumber = phoneNumber;
        }
    }
}

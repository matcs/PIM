using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models.PersonModel
{
    public class Telephone
    {
        [Key]
        public long TelephoneId { get; set; }
        [Column(TypeName = "VARCHAR(5)")]
        public String DDD { get; set; }
        [Column(TypeName = "VARCHAR(11)")]
        public String TelephoneNumber { get; set; }

        [ForeignKey("Person")]
        public long PersonId { get; set; }

        public Telephone() { }

        public Telephone(long telephoneId, string dDD, string telephoneNumber, long personId)
        {
            TelephoneId = telephoneId;
            DDD = dDD;
            TelephoneNumber = telephoneNumber;
            PersonId = personId;
        }
    }
}

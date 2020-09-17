using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models.PersonModel
{
    public class Telephone
    {
        [Key]
        public long TelephoneId { get; set; }
        public String DDD { get; set; }
        public String TelephoneNumber { get; set; }

        public Person Person { get; set; }

        public Telephone() { }

        public Telephone(long telephoneId, string dDD, string telephoneNumber, Person person)
        {
            TelephoneId = telephoneId;
            DDD = dDD;
            TelephoneNumber = telephoneNumber;
            Person = person;
        }
    }
}

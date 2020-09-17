using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models.PersonModel
{
    public class Person
    {
        [Key]
        public long PersonId { get; set; }
        [Column(TypeName = "VARCHAR(70)")]
        public String PesronName { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public String SocialName { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        public String Email { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public String Password { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        public String CPF { get; set; }
        public DateTime BirthDay { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        public String Role { get; set; }

        public Person() { }

        public Person(long personId, string pesronName, string socialName, string email, string password, string cPF, DateTime birthDay, string role)
        {
            PersonId = personId;
            PesronName = pesronName;
            SocialName = socialName;
            Email = email;
            Password = password;
            CPF = cPF;
            BirthDay = birthDay;
            Role = role;
        }
    }
}

using Microsoft.AspNetCore.Identity;
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
        public String PersonFirstName { get; set; }
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

        public override string ToString()
        {
            return "Person: "+PersonId+" "+PersonFirstName+" "+Email+" "+Password+" "+CPF+" "+Role;
        }

        public Person() { }

        public Person(long personId)
        {
            PersonId = personId;
        }

        public Person(Person person)
        {
            PersonId = person.PersonId;
            PersonFirstName = person.PersonFirstName;
            SocialName = person.SocialName;
            Email = person.Email;
            Password = person.Password;
            CPF = person.CPF;
            BirthDay = person.BirthDay;
            Role = person.Role;
        }

        public Person(long personId, string personName, string socialName, string email, string password, string cPF, DateTime birthDay, string role)
        {
            PersonId = personId;
            PersonFirstName = personName;
            SocialName = socialName;
            Email = email;
            Password = password;
            CPF = cPF;
            BirthDay = birthDay;
            Role = role;
        }
    }
}

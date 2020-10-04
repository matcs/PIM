using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models.Person
{
    public class Person : IdentityUser
    {
        [Key]
        public long PersonId { get; set; }
        [Column(TypeName = "VARCHAR(70)")]
        public string First_Name { get; set; }
        [Column(TypeName = "VARCHAR(70)")]
        public string Last_Name { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public String SocialName { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        public override String Email { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public String Password { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        public String CPF { get; set; }
        public DateTime BirthDay { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        public String Role { get; set; }

        public override string ToString()
        {
            return "Person: "+PersonId+" "+First_Name+" "+Email+" "+Password+" "+CPF+" "+Role;
        }

        public Person() { }

        public Person(long personId, string firstName, string lastName, string socialName, string email, string password, string cPF, DateTime birthDay, string role)
        {
            PersonId = personId;
            First_Name = firstName;
            Last_Name = lastName;
            SocialName = socialName;
            Email = email;
            Password = password;
            CPF = cPF;
            BirthDay = birthDay;
            Role = role;
        }
    }
}

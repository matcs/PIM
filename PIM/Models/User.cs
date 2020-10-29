using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "NVARCHAR(40)")]
        public string Id { get; set; }

        [Column(TypeName = "VARCHAR(70)")]
        public string FirstName { get; set; }

        [Column(TypeName = "VARCHAR(70)")]
        public string LastName { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string SocialName { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(30)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Password { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }

        [Column(TypeName = "VARCHAR(15)")]
        public string Role { get; set; }

        public List<Telephone> Telephones { get; set; }

        public User() { }

        public User(string id, string firstName, string lastName, string socialName, string email, string password, DateTime birthDay, string role, List<Telephone> telephones)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            SocialName = socialName;
            Email = email;
            Password = password;
            BirthDay = birthDay;
            Role = role;
            Telephones = telephones;
        }
    }
}
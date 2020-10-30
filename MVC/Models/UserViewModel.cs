using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class UserViewModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SocialName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime BirthDay { get; set; }

        public string Role { get; set; }

        public UserViewModel() { }

        public UserViewModel(string id, string firstName, string lastName, string socialName, string email, string password, DateTime birthDay, string role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            SocialName = socialName;
            Email = email;
            Password = password;
            BirthDay = birthDay;
            Role = role;
        }
    }
}

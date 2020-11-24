using System;

namespace Main.Models
{
    class Admin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDay { get; set; }
        public string Role { get; set; }

        public Admin() { }
        
        public Admin(string firstName, string lastName, string socialName, string email, string password, DateTime birthDay)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialName = socialName;
            Email = email;
            Password = password;
            BirthDay = birthDay;
            Role = "ADMIN";
        }
    }
}

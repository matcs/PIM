using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models
{    
    public class User : IdentityUser
    {        
        [Column(TypeName = "VARCHAR(70)")]
        public string First_Name { get; set; }
        [Column(TypeName = "VARCHAR(70)")]
        public string Last_Name { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string SocialName { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        public override string Email { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Password { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        public string CPF { get; set; }
        public DateTime BirthDay { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        public string Role { get; set; }

    }
}

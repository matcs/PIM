using PIM.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models.User
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        public bool AccountStatus { get; set; }
        public Person Person { get; set; }

    }
}

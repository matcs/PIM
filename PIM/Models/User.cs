using PIM.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models.User
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        public bool AccountStatus { get; set; }

        [ForeignKey("Person")]
        public long PersonId { get; set; }



    }
}

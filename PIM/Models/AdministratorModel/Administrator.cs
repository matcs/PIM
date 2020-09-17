using PIM.Models.PersonModel;
using PIM.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models.Administrator
{
    public class Administrator
    {
        [Key]
        public long AdministratorId { get; set; }
        public Person Person { get; set; }
    }
}
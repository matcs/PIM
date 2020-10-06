using PIM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models
{
    public class Administrator
    {
        [Key]
        public long AdministratorId { get; set; }
        
        [ForeignKey("Person")]
        public long PersonId { get; set; }

        public Administrator() { }

        public Administrator(long administratorId, long personId)
        {
            AdministratorId = administratorId;
            PersonId = personId;
        }
    }
}
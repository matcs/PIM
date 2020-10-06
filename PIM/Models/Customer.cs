using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models
{
    public class Customer
    {
        [Key]
        public long CustumersId { get; set; }
        public bool AccountStatus { get; set; }

        [ForeignKey("Person")]
        public long PersonId { get; set; }
    }
}

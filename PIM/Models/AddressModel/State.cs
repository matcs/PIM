using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models
{
    public class State
    {
        [Key]
        public long StateId { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        public String StateName { get; set; }
        public Address Address { get; set; }

        public State() { }
        
        public State(long stateId, string stateName, Address address)
        {
            StateId = stateId;
            StateName = stateName;
            Address = address;
        }
    }
}

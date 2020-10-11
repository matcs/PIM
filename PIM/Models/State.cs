using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM.Models
{
    public class State
    {
        [Key]
        public long StateId { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(30)")]
        public string StateName { get; set; }

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

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM.Models
{
    public class State
    {
        [Key]
        public long StateId { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        public string StateName { get; set; }

        [ForeignKey("Address")]
        public long AddressId { get; set; }

        public State() { }

        public State(long stateId, string stateName, long addressId)
        {
            StateId = stateId;
            StateName = stateName;
            AddressId = addressId;
        }
    }
}

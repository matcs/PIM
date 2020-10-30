using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class StateViewModel
    {
        public long StateId { get; set; }

        public string StateName { get; set; }

        public long AddressId { get; set; }

        public StateViewModel() { }

        public StateViewModel(long stateId, string stateName, long addressId)
        {
            StateId = stateId;
            StateName = stateName;
            AddressId = addressId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class TelephoneViewModel
    {
        public long TelephoneId { get; set; }

        public string DDD { get; set; }

        public string PhoneNumber { get; set; }

        public string UserId { get; set; }

        public TelephoneViewModel() { }

        public TelephoneViewModel(long telephoneId, string dDD, string phoneNumber, string userId)
        {
            TelephoneId = telephoneId;
            DDD = dDD;
            PhoneNumber = phoneNumber;
            UserId = userId;
        }
    }
}

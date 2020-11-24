using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Models
{
    class WorkRecordBooklet
    {
        public string Number { get; set; }
        public string Serial { get; set; }
        public string BirthPlace { get; set; }
        public DateTime BirthDate { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public DateTime ShippingDate { get; set; }
        public string UserId { get; set; }

        public WorkRecordBooklet(string number, string serial, string birthPlace, DateTime birthDate, string fatherName, string motherName, DateTime shippingDate, string userId)
        {
            Number = number;
            Serial = serial;
            BirthPlace = birthPlace;
            BirthDate = birthDate;
            FatherName = fatherName;
            MotherName = motherName;
            ShippingDate = shippingDate;
            UserId = userId;
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM.Models
{
    //AKA: Carteira de Trabalho
    public class WorkRecordBooklet
    {
        [Key]
        public long WorkRecordBookletId { get; set; }

        [Column(TypeName = "NVARCHAR(10)")]
        [Index(IsUnique = true)]
        public string Number { get; set; }

        [Column(TypeName = "NVARCHAR(12)")]
        public string Serial { get; set; }

        [Column(TypeName = "NVARCHAR(10)")]
        public string BirthPlace { get; set; }

        public DateTime BirthDate { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public DateTime ShippingDate { get; set; }

        [ForeignKey("Administrator")]
        public long AdministratorId { get; set; }

        public WorkRecordBooklet() { }

        public WorkRecordBooklet(long workRecordBookletId, string number, string serial, string birthPlace, DateTime birthDate, string fatherName, string motherName, DateTime shippingDate, long administratorId)
        {
            WorkRecordBookletId = workRecordBookletId;
            Number = number;
            Serial = serial;
            BirthPlace = birthPlace;
            BirthDate = birthDate;
            FatherName = fatherName;
            MotherName = motherName;
            ShippingDate = shippingDate;
            AdministratorId = administratorId;
        }
    }
}

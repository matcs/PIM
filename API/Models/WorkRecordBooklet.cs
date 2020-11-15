using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    //AKA: Carteira de Trabalho
    public class WorkRecordBooklet
    {
        [Key]
        public long WorkRecordBookletId { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(10)")]
        [Index(IsUnique = true)]
        public string Number { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(12)")]
        public string Serial { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(30)")]
        public string BirthPlace { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        public string FatherName { get; set; }

        [Required]
        public string MotherName { get; set; }

        [Required]
        public DateTime ShippingDate { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public User User { get; set; }

        public WorkRecordBooklet() { }

        public WorkRecordBooklet(long workRecordBookletId, string number, string serial, string birthPlace, DateTime birthDate, string fatherName, string motherName, DateTime shippingDate, string userId)
        {
            WorkRecordBookletId = workRecordBookletId;
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

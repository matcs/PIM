using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM.Models
{
    public class Administrator
    {
        [Key]
        public long AdministratorId { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }

        public Administrator() { }

        public Administrator(long administratorId, long userId)
        {
            AdministratorId = administratorId;
            UserId = userId;
        }
    }
}

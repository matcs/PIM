using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Administrator
    {
        [Key]
        public long AdministratorId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        
        public User User { get; set; }

        public Administrator() { }

        public Administrator(long administratorId, User user)
        {
            AdministratorId = administratorId;
            User = user;
        }
    }
}

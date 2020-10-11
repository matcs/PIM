using System.ComponentModel.DataAnnotations;

namespace PIM.Models
{
    public class Administrator
    {
        [Key]
        public long AdministratorId { get; set; }

        public User User { get; set; }

        public Administrator() { }

        public Administrator(long administratorId, User user)
        {
            AdministratorId = administratorId;
            User = user;
        }
    }
}

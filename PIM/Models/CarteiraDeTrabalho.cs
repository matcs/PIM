using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM.Models
{
    public class CarteiraDeTrabalho
    {
        [Key]
        public long CarteiraDeTrabalhoId { get; set; }

        [ForeignKey("Administrator")]
        public long AdministratorId { get; set; }

        public CarteiraDeTrabalho() { }

        public CarteiraDeTrabalho(long carteiraDeTrabalhoId, long administratorId)
        {
            CarteiraDeTrabalhoId = carteiraDeTrabalhoId;
            AdministratorId = administratorId;
        }
    }
}

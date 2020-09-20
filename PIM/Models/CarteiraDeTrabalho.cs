using PIM.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models.Administrator
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

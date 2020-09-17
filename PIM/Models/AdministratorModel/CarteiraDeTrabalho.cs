using PIM.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models.Administrator
{
    public class CarteiraDeTrabalho
    {
        [Key]
        public long CarteiraDeTrabalhoId { get; set; }
        public Administrator Administrator { get; set; }

        public CarteiraDeTrabalho() { }

        public CarteiraDeTrabalho(long carteiraDeTrabalhoId, Administrator administrator)
        {
            CarteiraDeTrabalhoId = carteiraDeTrabalhoId;
            Administrator = administrator;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models
{
    public class RegistroGeral
    {
        [Key]
        public long RegistroGeralId { get; set; }
        [Column(TypeName = "CHAR(10)")]
        public string RegistroGeralCod { get; set; }
        [Column(TypeName = "VARCHAR(7)")]
        public string OrgaoExpedidor { get; set; }
        public DateTime DataExpedicao { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }

        public RegistroGeral() { }

        public RegistroGeral(long registroGeralId, string registroGeralCod, string orgaoExpedidor, DateTime dataExpedicao, long userId)
        {
            RegistroGeralId = registroGeralId;
            RegistroGeralCod = registroGeralCod;
            OrgaoExpedidor = orgaoExpedidor;
            DataExpedicao = dataExpedicao;
            UserId = userId;
        }
    }
}

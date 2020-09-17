using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Models.PersonModel
{
    public class Identity
    {
        [Key]
        public long IdentitryId { get; set; }
        [Column(TypeName = "CHAR(10)")]
        public String RegistroGeral { get; set; }
        [Column(TypeName = "VARCHAR(7)")]
        public String OrgaoExpedidor { get; set; }
        public DateTime DataExpedicao { get; set; }

        public Person Person { get; set; }

        public Identity() { }

        public Identity(long identitryId, string registroGeral, string orgaoExpedidor, DateTime dataExpedicao, Person person)
        {
            IdentitryId = identitryId;
            RegistroGeral = registroGeral;
            OrgaoExpedidor = orgaoExpedidor;
            DataExpedicao = dataExpedicao;
            Person = person;
        }
    }
}

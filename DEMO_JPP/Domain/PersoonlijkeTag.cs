using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.Domain
{
    public class PersoonlijkeTag
    {
        [Key]
        public int id { get; set; }
        public string inhoud { get; set; }

        public virtual ICollection<DossierAntwoord> dossierAntwoorden { get; set; }
        public virtual ICollection<AgendaAntwoord> agendaAntwoorden { get; set; }
        public virtual ICollection<Voorstel> voorstellen { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JPP.Domain
{
    public class Tag
    {

        [Key]
        public int id { get; set; }
        public string inhoud { get; set; }

        public virtual ICollection<DossierAntwoord> dossierAntwoorden { get; set; }
        public virtual ICollection<AgendaAntwoord> agendaAntwoorden { get; set; }
        public virtual ICollection<Voorstel> voorstellen { get; set; }

    }
}

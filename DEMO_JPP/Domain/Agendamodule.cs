using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.Domain
{
    public class Agendamodule
    {
        [Key]
        public int id { get; set; }
        public virtual Beloning beloning { get; set; }
        public string gebruikerNaam { get; set; }
        public virtual Thema thema { get; set; }
        public virtual CentraleVraag centraleVraag { get; set; }

        public string naam { get; set; }
        public ModuleStatus status { get; set; }
        public DateTime beginDatum { get; set; }
        public DateTime eindDatum { get; set; }

        public virtual ICollection<AgendaAntwoord> agendaAntwoorden { get; set; }
        public virtual ICollection<Voorstel> voorstellen { get; set; }
    }
}

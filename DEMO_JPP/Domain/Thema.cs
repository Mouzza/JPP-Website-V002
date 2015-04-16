using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JPP.Domain
{
    public class Thema
    {
        [Key]
        public int id { get; set; }
        public string inhoud { get; set; }


        public virtual ICollection<Agendamodule> agendaModules { get; set; }
        public virtual ICollection<Dossiermodule> dossierModules { get; set; }

    }
}

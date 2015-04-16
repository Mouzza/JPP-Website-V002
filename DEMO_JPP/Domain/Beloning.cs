using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.Domain
{
    public class Beloning
    {
        [Key]
        public int id { get; set; }
        public string naam { get; set; }
        public string beschrijving { get; set; }

        public virtual ICollection<Agendamodule> agendaModules { get; set; }
        public virtual ICollection<Dossiermodule> dossierModules { get; set; }
        
    }
}

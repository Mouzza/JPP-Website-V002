using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.Domain
{
    public class CentraleVraag
    {
        //[Key]
        //public int id { get; set; }
        public string inhoud { get; set; }
        public string extraInfo { get; set; }
        public DateTime datum { get; set; }
        public int aantalWinAntwoorden { get; set; }

        [Key, ForeignKey("dossiermodule")]
        public int dossiermoduleId { get; set; }

        public virtual Dossiermodule dossiermodule { get; set; }
      

 


    }
}

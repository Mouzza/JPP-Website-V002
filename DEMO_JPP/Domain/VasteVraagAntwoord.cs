using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JPP.Domain
{
    public class VasteVraagAntwoord
    {
        [Key]
        public int id { get; set; }

        public string inhoud { get; set; }
        public string extraInfo { get; set; }
        public DateTime datum { get; set; }

        public virtual VasteVraag vasteVraag { get; set; }




    }
}

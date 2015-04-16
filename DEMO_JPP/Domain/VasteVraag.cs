using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.Domain
{
    public class VasteVraag
    {
        [Key]
        public int id { get; set; }

        public virtual ICollection<VasteVraagAntwoord> vasteVraagAntwoorden { get; set; }


        public string inhoud { get; set; }
        public string extraInfo { get; set; }
        public Boolean verplicht { get; set; }




    }
}

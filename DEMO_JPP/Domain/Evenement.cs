using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.Domain
{
    public class Evenement
    {
    

        [Key, ForeignKey("dossierantwoord")]
        public int dossierantwoordId { get; set; }

        public virtual DossierAntwoord dossierantwoord { get; set; }
      
        public string titel { get; set; }
        public string Locatie { get; set; }
        public DateTime startDatum { get; set; }
        public DateTime eindDatum { get; set; }
        public string facebookPageUrl { get; set; }


    }
}

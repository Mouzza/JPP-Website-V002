using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JPP.Domain
{
    public class DossierAntwoord
    {
        [Key]
        public int id { get; set; }
        public virtual Dossiermodule dossierModule { get; set; }

        public string gebruikerNaam { get; set; }
        public string medebeheerderId { get; set; }
        public string expertNaam { get; set; }

        public string inhoud { get; set; }
        public string extraInfo { get; set; }
        public DateTime datum { get; set; }
        public int aantalStemmen { get; set; }
        public double percentageVolledigheid { get; set; }
        public Boolean statusOnline { get; set; }
        public string extraVraag { get; set; }
        public int aantalFlags { get; set; }

        public virtual Evenement evenement { get; set; }

        public virtual ICollection<Comment> comments { get; set; }

        public virtual ICollection<Tag> tags { get; set; }
        public virtual ICollection<PersoonlijkeTag> persoonlijkeTags { get; set; }
    }
}

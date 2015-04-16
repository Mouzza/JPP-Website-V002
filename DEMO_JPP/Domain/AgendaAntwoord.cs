using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JPP.Domain
{
    public class AgendaAntwoord
    {

        [Key]
        public int id { get; set; }
        public virtual Agendamodule agendaModule { get; set; }

        public string gebruikerNaam { get; set; }
        public string medebeheerderNaam { get; set; }
        public string expertNaam { get; set; }

        public string inhoud { get; set; }
        public string extraInfo { get; set; }
        public DateTime datum { get; set; }
        public int aantalStemmen { get; set; }
        public Boolean statusOnline { get; set; }
        public int aantalFlags { get; set; }

        public virtual ICollection<Tag> tags { get; set; }
        public virtual ICollection<PersoonlijkeTag> persoonlijkeTags { get; set; }
      

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JPP.Domain
{
    public class Voorstel
    {

        [Key]
        public int id { get; set; }

        public virtual Agendamodule agendaModule { get; set; }
        public string gebruikerNaam { get; set; }
        public string inhoud { get; set; }
        public string extraInfo { get; set; }
        public DateTime datum { get; set; }
        public int aantalStemmen { get; set; }

        public virtual ICollection<Tag> tags { get; set; }
        public virtual ICollection<PersoonlijkeTag> persoonlijkeTags { get; set; }



    }
}

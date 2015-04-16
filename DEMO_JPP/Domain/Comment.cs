using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JPP.Domain
{
    public class Comment
    {
        [Key]
        public int id { get; set; }
        public string gebruikerNaam { get; set; }

        public string inhoud { get; set; }
        public DateTime datum { get; set; }
        public int aantalFlags { get; set; }



    }
}

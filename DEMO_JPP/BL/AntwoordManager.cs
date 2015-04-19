using JPP.DAL.EF;
using JPP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.BL
{
    public class AntwoordManager : IAntwoordManager
    {


      private readonly IAntwoordMapper antwMapper;

      public AntwoordManager()
        {
            antwMapper = new AntwoordMapper();

        }


        public DossierAntwoord GetDossierAntwoord(int id)
       {
         return antwMapper.ReadDossierAntwoord(id);
        }

        public AgendaAntwoord GetAgendaAntwoord(int id)
        {
            return antwMapper.ReadAgendaAntwoord(id);
        }

        public IEnumerable<DossierAntwoord> GetAllDossierAntwoorden()
        {
            return antwMapper.ReadAllDossierAntwoorden();

        }

        public IEnumerable<AgendaAntwoord> GetAllAgendaAntwoorden()
        {
           return antwMapper.ReadAllAgendaAntwoorden();
        }

        public IEnumerable<DossierAntwoord> GetDossierAntwoorden(int dossierId)
        {
            return antwMapper.ReadDossierAntwoorden(dossierId);
        }

        public IEnumerable<AgendaAntwoord> GetAgendaAntwoorden(int agendaId)
        {
            throw new NotImplementedException();
        }
    }
}

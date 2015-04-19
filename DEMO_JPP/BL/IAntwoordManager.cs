using JPP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.BL
{
    public interface IAntwoordManager
    {
        DossierAntwoord GetDossierAntwoord(int id);
        AgendaAntwoord GetAgendaAntwoord(int id);

        IEnumerable<DossierAntwoord> GetAllDossierAntwoorden();
        IEnumerable<AgendaAntwoord> GetAllAgendaAntwoorden();

        IEnumerable<DossierAntwoord> GetDossierAntwoorden(int dossierId);
        IEnumerable<AgendaAntwoord> GetAgendaAntwoorden(int agendaId);

    }
}

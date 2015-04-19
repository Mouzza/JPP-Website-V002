using JPP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.DAL.EF
{
    public interface IAntwoordMapper
    {

        DossierAntwoord ReadDossierAntwoord(int id);
        AgendaAntwoord ReadAgendaAntwoord(int id);

        IEnumerable<DossierAntwoord> ReadAllDossierAntwoorden();
        IEnumerable<AgendaAntwoord> ReadAllAgendaAntwoorden();


        IEnumerable<DossierAntwoord> ReadDossierAntwoorden(int dossierId);
        IEnumerable<AgendaAntwoord> ReadAgendaAntwoorden(int agendaId);

    }
}

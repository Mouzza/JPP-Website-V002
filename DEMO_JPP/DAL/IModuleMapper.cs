using JPP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.DAL.EF
{
    public interface IModuleMapper
    {
        Dossiermodule ReadDossiermodule(int id);
        Agendamodule ReadAgendamodule(int id);

        void DeleteDossiermodule(int id);
        void DeleteAgendamodule(int id);

        void UpdateDossiermodule(Dossiermodule dossiermodule);
        void UpdateAgendamodule(Agendamodule agendamodule);

        IEnumerable<Dossiermodule> ReadAllDossiermodules();
        IEnumerable<Agendamodule> ReadAllAgendamodules();
        Dossiermodule CreateDossiermodule(Dossiermodule dossiermodule);
        Agendamodule CreateAgendamodule(Agendamodule agendamodule);
    }
}

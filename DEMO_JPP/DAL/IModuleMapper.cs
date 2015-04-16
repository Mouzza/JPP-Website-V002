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
        IEnumerable<Dossiermodule> ReadAllDossiermodules();
        IEnumerable<Agendamodule> ReadAllAgendamodules();
        Dossiermodule CreateDossiermodule(Dossiermodule dossiermodule);
        Agendamodule CreateAgendamodule(Agendamodule agendamodule);
    }
}

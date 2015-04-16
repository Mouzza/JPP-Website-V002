using JPP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.DAL.EF
{
    public class ModuleMapper : IModuleMapper
    {

        EFDbContext dbcontext;

        public ModuleMapper()
        {

            dbcontext = new EFDbContext();
        }
        public IEnumerable<Dossiermodule> ReadAllDossiermodules()
        {
            return dbcontext.dossiermodules.ToList();

        }
        public IEnumerable<Agendamodule> ReadAllAgendamodules()
        {
            return dbcontext.agendamodules.ToList();

        }

        public Dossiermodule CreateDossiermodule(Dossiermodule dossiermodule)
        {
            dbcontext.centraleVragen.Add(dossiermodule.centraleVraag);
            dbcontext.themas.Add(dossiermodule.thema);
            dbcontext.dossiermodules.Add(dossiermodule);
            dbcontext.SaveChanges();

            return dossiermodule;
        }
        public Agendamodule CreateAgendamodule(Agendamodule agendamodule)
        {
            dbcontext.agendamodules.Add(agendamodule);
            dbcontext.SaveChanges();

            return agendamodule;
        }
    }
}

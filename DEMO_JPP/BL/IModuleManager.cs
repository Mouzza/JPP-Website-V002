using JPP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.BL
{
    public interface IModuleManager
    {
        IEnumerable<Dossiermodule> GetAllDossierModules();
        IEnumerable<Agendamodule> GetAllAgendaModules();
        Dossiermodule AddDossierModule(string AdminNaam, string naam,
             DateTime beginDatum, DateTime eindDatum, double volledigheidsPercentage, string themaInhoud, string centraleVraag,
            string vastevraag, bool verplicht, string beloningNaam, string beloningDesc, int aantalWinnaars);


    }
}

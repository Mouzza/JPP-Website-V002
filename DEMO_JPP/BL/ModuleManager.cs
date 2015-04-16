using JPP.DAL.EF;
using JPP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPP.BL
{
    public class ModuleManager : IModuleManager
    {
        private readonly IModuleMapper moduleMapper;

        public ModuleManager()
        {
            moduleMapper = new ModuleMapper();

        }
        public IEnumerable<Dossiermodule> GetAllDossierModules()
        {
            return moduleMapper.ReadAllDossiermodules();

        }
        public IEnumerable<Agendamodule> GetAllAgendaModules()
        {
            return moduleMapper.ReadAllAgendamodules();

        }

        public Dossiermodule AddDossierModule(string AdminNaam, string naam,
             DateTime beginDatum, DateTime eindDatum, double volledigheidsPercentage, string themaInhoud, string centraleVraag, 
            string vastevraag, Boolean verplicht, string beloningNaam, string beloningDesc, int aantalWinnaars )
        {
            CentraleVraag cv = new CentraleVraag()
            {
                inhoud = centraleVraag,
                datum = DateTime.Now,
                extraInfo = "test",
                aantalWinAntwoorden=aantalWinnaars
               

            };
            Thema thema = new Thema()
            {
                inhoud = themaInhoud


            };

            VasteVraag vasteVraag = new VasteVraag()
            {
                inhoud=vastevraag,
                verplicht=verplicht
            };
            Beloning beloning = new Beloning()
            {
                naam=beloningNaam,
                beschrijving =beloningDesc
            };
            Dossiermodule dosModule = new Dossiermodule()
            {
                AdminNaam = AdminNaam,
                naam =naam,
                volledigheidsPercentage = volledigheidsPercentage,
                beginDatum = beginDatum,
                eindDatum = eindDatum,
                status = ModuleStatus.Open,
                vasteVragen = new List<VasteVraag>()
            };

            dosModule.beloning = beloning;
            dosModule.vasteVragen.Add(vasteVraag);
            dosModule.centraleVraag = cv;
            dosModule.thema = thema;

            return moduleMapper.CreateDossiermodule(dosModule);


        }
        public Agendamodule AddAgendaModule(string AdminNaam, string naam,
        double volledigheidsPercentage, DateTime beginDatum, DateTime eindDatum)
        {
            //CentraleVraag cv = new CentraleVraag()
            //{
            //    inhoud = centraleVraag,
            //    aantalWinAntwoorden = aantalWinnaars,
            //    extraInfo = extraInfo

            //};

            Agendamodule agendaModule = new Agendamodule()
            {
                gebruikerNaam = AdminNaam,
                naam = naam,
                beginDatum = beginDatum,
                eindDatum = eindDatum

            };
            //agendaModule.centraleVraag = cv;

            return moduleMapper.CreateAgendamodule(agendaModule);

        }

        public object AddDossierModule(Dossiermodule dosModule)
        {
            throw new NotImplementedException();
        }
    }
}

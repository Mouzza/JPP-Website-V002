using JPP.BL;
using JPP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using JPP.UI.Web.MVC.Models;

namespace JPP.UI.Web.MVC.Controllers
{
    [Authorize (Roles="Admin")]
    public class ModuleController : Controller
    {

        ModuleManager moduleManager = new ModuleManager();


        // GET: Module
        public ActionResult Index()
        {
            IEnumerable<Dossiermodule> dossierModules = moduleManager.GetAllDossierModules();

            return View(dossierModules);
        }

        // GET: Module/Create
        public ActionResult Create()
        {
      
            return View();
        }

        // POST: Module/Create
        [HttpPost]
        public ActionResult Create(DossiermoduleView dosModule)
        {
            try
            {

                // TODO: Add insert logic here
              moduleManager.AddDossierModule(User.Identity.GetUserName(), dosModule.dossiermodule.naam,
                    dosModule.dossiermodule.beginDatum, dosModule.dossiermodule.eindDatum, dosModule.dossiermodule.volledigheidsPercentage, dosModule.dossiermodule.thema.inhoud,
                    dosModule.dossiermodule.centraleVraag.inhoud,
                    dosModule.vasteVraag.inhoud, dosModule.vasteVraag.verplicht,
                    dosModule.dossiermodule.beloning.naam, dosModule.dossiermodule.beloning.beschrijving, dosModule.dossiermodule.centraleVraag.aantalWinAntwoorden
                    );
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

    }
}
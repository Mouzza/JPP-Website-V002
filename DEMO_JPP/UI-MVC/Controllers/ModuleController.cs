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

    public class ModuleController : Controller
    {

        ModuleManager moduleManager = new ModuleManager();


        // GET: Module
       [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            IEnumerable<Dossiermodule> dossierModules = moduleManager.GetAllDossierModules();

            return View(dossierModules);
        }

        public ActionResult Actief()
        {
           Dossiermodule actieveDossiermodule = moduleManager.GetAllDossierModules().Where(dmod => dmod.status == ModuleStatus.Open).First();

           return View(actieveDossiermodule);
        }
       [Authorize(Roles = "Admin")]
        public ActionResult Details(int id)
        {
            Dossiermodule dossiermodule = moduleManager.GetDossiermodule(id);

            return View(dossiermodule);
        }
       [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            Dossiermodule dossiermodule = moduleManager.GetDossiermodule(id);

            return View(dossiermodule);
        }
        // POST: Module/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                moduleManager.RemoveDossiermodule(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
       
            Dossiermodule dossiermodule = moduleManager.GetDossiermodule(id);

            return View(dossiermodule);
        }
        // POST: Module/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id, Dossiermodule dossiermodule)
        {
            Dossiermodule dm = moduleManager.GetDossiermodule(id);
            try
            {
                string ms = Request.Form["MyType"];
                if (ms.Length>0 && ms != "0")
                {
             
                int  msi = Int32.Parse(ms);
             
                    ModuleStatus mss = (ModuleStatus)msi;
                    dossiermodule.status = mss;
                }
                else
                {
                    dossiermodule.status = dm.status;
                }
              
                // TODO: Add update logic here

                moduleManager.ChangeDossiermodule(dossiermodule);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Module/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {

            return View();
        }

        // POST: Module/Create
        [HttpPost]
        [Authorize(Roles = "Admin")]
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
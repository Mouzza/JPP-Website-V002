using JPP.BL;
using JPP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace JPP.UI.Web.MVC.Controllers
{
    public class AntwoordController : Controller
    {
        AntwoordManager antwManager = new AntwoordManager();
        ModuleManager dossManager = new ModuleManager();
        // GET: Antwoord
        public ActionResult Index()
        {
            return View();
        
        }

        //Antwoord/Lijst

        public ActionResult _partialAntwoordLijst(int? page)
        {

            int pageSize = 5;
            int pageNumber = (page ?? 1);
            
            Dossiermodule dossiermodule = dossManager.GetAllDossierModules().Where(dos => dos.status == ModuleStatus.Open).First();
            IEnumerable<DossierAntwoord> dossierAntwoorden = antwManager.GetDossierAntwoorden(dossiermodule.id);

            ViewBag.Aantal = dossierAntwoorden.Count();
            return PartialView(dossierAntwoorden.ToPagedList(pageNumber, pageSize));

        }
        //Antwoord/Lijst
        public ActionResult Lijst(int id)
        {
            IEnumerable<DossierAntwoord> dossierAntwoorden = antwManager.GetDossierAntwoorden(id);
            return View(dossierAntwoorden);

        }
        // GET: Antwoord/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Antwoord/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Antwoord/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Antwoord/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Antwoord/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Antwoord/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Antwoord/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using JPP.Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace JPP.UI.Web.MVC.Models
{
    public class DossiermoduleView
    {
        public Dossiermodule dossiermodule { get; set; }
        public VasteVraag vasteVraag { get; set; }

    }

}
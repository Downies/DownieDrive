using DownieDrive.Web.Models.Drive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DownieDrive.Web.Controllers
{
    /// <summary>
    /// Representiert den Drive Controller.
    /// In diesen Controller, gelangt man nur wenn man Eingeloggt ist. 
    /// Hier werden Dateien, Ordner erstellen, gelöscht & verschoben.
    /// </summary>
    public class DriveController : Controller
    {
        /// <summary>
        /// Gibt die Index View zurück, welche eine Übersicht aller Dateien
        /// des Users darstellt
        /// </summary>
        /// <returns>Die Index View</returns>
        public ActionResult Index()
        {
            return View(new DriveViewModel());
        }

        public ActionResult Menu()
        {
            return PartialView("~/Views/Shared/DriveMenu.cshtml");
        }
    }
}
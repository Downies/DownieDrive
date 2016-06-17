using DownieDrive.Businesslogic;
using DownieDrive.Businesslogic.Repositories.DateiRepository;
using DownieDrive.Web.Models.UploadFileModal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace DownieDrive.Web.Controllers
{
    /// <summary>
    /// Controller für File aktionen
    /// </summary>
    public class FileController : Controller
    {
        //Nicht zugreifen, nur über Property!
        private string userFilesPath = ConfigurationManager.AppSettings["UserFilePath"];

        private DateiRepository dateiRepository;
        public FileController(DateiRepository dateiRepsitory)
        {
            this.dateiRepository = dateiRepository;
        }

        /// <summary>
        /// Gibt den UserFilesPath zurück und legt diesen fest und erstellt den Ordner, falls er nicht vorhanden ist.
        /// </summary>
        private string UserFilesPath {
            get
            {
                string path = Server.MapPath(userFilesPath);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                return path;
            }
        }
        /// <summary>
        /// Ladet ein File hoch und leitet zur Drive Index View zurück
        /// </summary>
        /// <param name="uploadFileModalViewModel">Das UploadFileModalViewModel</param>
        /// <returns>Die Drive Index View</returns>
        [HttpPost]
        public ActionResult Upload(UploadFileModalViewModel uploadFileModalViewModel)
        {
            // Pfad für die User Files
            HttpPostedFileBase file = uploadFileModalViewModel.Datei;
            if (file != null && file.ContentLength > 0)
            {
                string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                string fileExtension = Path.GetExtension(file.FileName);
                Datei datei = new Datei()
                { 
                    Name = fileName,
                    Dateigroesse = file.ContentLength,
                    Dateityp = fileExtension
                };
                
                string uuid = dateiRepository.InsertDatei(datei);

                string path = Path.Combine(UserFilesPath, uuid);
                file.SaveAs(path);
            }


            return RedirectToAction("Index", "Drive");
        }
    }
}
using DownieDrive.Web.Models.CreateFolderModal;
using DownieDrive.Web.Models.UploadFileModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DownieDrive.Web.Models.Drive
{
    public class DriveViewModel
    {
        public DriveViewModel()
        {
            CreateFolderModalViewModel = new CreateFolderModalViewModel();
            UploadFileModalViewModel = new UploadFileModalViewModel();
        }
        /// <summary>
        /// Gibt das CreateFolderModalViewModel zurück und legt dies fest
        /// </summary>
        public CreateFolderModalViewModel CreateFolderModalViewModel{ get; set; }

        /// <summary>
        /// Gibt das UploadFileModalViewModel zurück und legt dies fest.
        /// </summary>
        public UploadFileModalViewModel UploadFileModalViewModel { get; set; }
    }
}
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
            CreateFolderModalViewModel = new CreateFolderModal.CreateFolderModalViewModel();
        }
        public CreateFolderModal.CreateFolderModalViewModel CreateFolderModalViewModel{ get; set; }
    }
}
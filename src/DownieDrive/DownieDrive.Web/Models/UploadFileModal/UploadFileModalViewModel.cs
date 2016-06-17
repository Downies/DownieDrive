using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DownieDrive.Web.Models.UploadFileModal
{
    /// <summary>
    /// Representiert das ViewModel für die UploadFileModal Partial View
    /// </summary>
    public class UploadFileModalViewModel
    {
        /// <summary>
        /// Gibt die Hochgeladene Datei zurück und legt diese fest
        /// </summary>
        public HttpPostedFileBase Datei { get; set; }
    }
}
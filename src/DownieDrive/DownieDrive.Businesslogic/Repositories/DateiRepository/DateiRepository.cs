using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownieDrive.Businesslogic.Repositories.DateiRepository
{
    /// <summary>
    /// Das Repository für Datei mutationen
    /// </summary>
    public class DateiRepository : IDateiRepository
    {
        /// <summary>
        /// Speichert die Dateidaten in der Datenbank ab und erstellt eine UUID für die Datei 
        /// </summary>
        /// <param name="datei">Die zu speichernde Datei</param>
        /// <returns>Die neu generierte UUID</returns>
        public string InsertDatei(Datei datei)
        {
            string guid = Guid.NewGuid().ToString();
            datei.UUID = guid;
            datei.Erstelldatum = DateTime.Now;
            datei.Aktiv = true;
            return guid;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownieDrive.Businesslogic
{
    public class Person : Metadaten
    {
        public int Id { get; set; }
        public string Benutzername { get; set; }
        public string Passwort { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int DowniePunkte { get; set; }
        public ProfilBild ProfilBild { get; set; }
        public string Beschreibung { get; set; }
        public bool Geschlecht { get; set; }
        public bool Aktiv { get; set; }

        public Level Level { get; set; }
        public Benutzerrolle Benutzerrolle { get; set; }

    }
}

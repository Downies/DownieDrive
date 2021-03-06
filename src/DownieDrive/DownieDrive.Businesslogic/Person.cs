﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownieDrive.Businesslogic
{
    public class Person : Metadaten
    {
        [Key]
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Passwort { get; set; }
        public int DowniePunkte { get; set; }
        public virtual ProfilBild ProfilBild { get; set; }
        public string Beschreibung { get; set; }
        public bool Geschlecht { get; set; }
        public int Level { get; set; }
   
        public virtual LevelFarbe LevelFarbe { get; set; }
        public virtual Benutzerrolle Benutzerrolle { get; set; }
        public virtual ObservableCollection<DriveContent> DriveContent { get; set; }
    }
}

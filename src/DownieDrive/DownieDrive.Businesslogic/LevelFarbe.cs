using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownieDrive.Businesslogic
{
    public class LevelFarbe : Metadaten
    {
        [Key]
        public int Id { get; set; }
        public string Beschreibung { get; set; }
        public int LevelAnforderung { get; set; }
    }
}

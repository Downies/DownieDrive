using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownieDrive.Businesslogic
{
    public class DriveObjekt : Metadaten
    {
        [Key]
        public int Id { get; set; }
        // entweder das
        public virtual Ordner OrdnerEigenschaften { get; set; }
        // oder das
        public virtual Datei DateiEigenschaften { get; set; }
        public virtual Ordner ParentOrdner { get; set; }
        public string UUID { get; set; }
        public string Name { get; set; }
    }
}

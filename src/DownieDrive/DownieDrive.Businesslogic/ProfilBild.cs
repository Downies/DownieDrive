﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownieDrive.Businesslogic
{
    public class ProfilBild : Metadaten
    {
        [Key]
        public int Id { get; set; }
        public byte[] Daten { get; set; }
    }
}

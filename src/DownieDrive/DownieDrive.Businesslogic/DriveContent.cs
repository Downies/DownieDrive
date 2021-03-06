﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownieDrive.Businesslogic
{
    public class DriveContent
    {
        [Key]
        public int Id { get; set; }
        public virtual Person Person { get; set; }
        public virtual ObservableCollection<DriveObjekt> DriveObjekte { get; set; }
    }
}

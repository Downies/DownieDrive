using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownieDrive.Businesslogic
{
    [Table("File")]
    public class File
    {
        [Key]
        public int Id { get; set; }

    }
}

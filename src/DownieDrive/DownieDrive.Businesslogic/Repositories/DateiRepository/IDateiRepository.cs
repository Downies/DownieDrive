using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownieDrive.Businesslogic.Repositories.DateiRepository
{
    public interface IDateiRepository
    {
        string InsertDatei(Datei datei);
    }
}

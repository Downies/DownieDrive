using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownieDrive.Businesslogic
{
    /// <summary>
    /// Datenbank Context Klasse für das DownieDrive. Über diese Klasse können Datenbank manipulationen vorgenommen werden.
    /// </summary>
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DownieContext : DbContext
    {
        private static string ConnectionStringName
        {
            get
            {
#if DEBUG
                return "Debug";
#else
                return "Prod";
#endif
            }
        }

        public DownieContext()
            : base(ConnectionStringName)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<File> Files { get; set; }
    }
}

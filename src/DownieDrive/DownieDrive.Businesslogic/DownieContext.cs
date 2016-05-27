using System.Data.Entity;

namespace DownieDrive.Businesslogic
{
    /// <summary>
    /// Datenbank Context Klasse für das DownieDrive. Über diese Klasse können Datenbank manipulationen vorgenommen werden.
    /// </summary>
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
            Database.SetInitializer<DownieContext>(new CreateDatabaseIfNotExists<DownieContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<File> Files { get; set; }
    }
}

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
                return "DownieDrive_Debug";
#else
                return "DownieDrive_Prod";
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

            modelBuilder.Entity<DriveObjekt>().HasOptional(x => x.ParentOrdner).WithMany().WillCascadeOnDelete(false);

        }
        //public DbSet<File> files { get; set; }

        public DbSet<Benutzerrolle> Benutzerrollen { get; set; }
        public DbSet<Datei> Dateien { get; set; }
        public DbSet<Ordner> Ordner { get; set; }
        public DbSet<DriveContent> DriveContent { get; set; }
        public DbSet<LevelFarbe> LevelFarben { get; set; }
        public DbSet<Person> Personen { get; set; }
        public DbSet<ProfilBild> ProfilBilder { get; set; }

    }
}

namespace DownieDrive.Businesslogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reinit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Benutzerrolles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dateis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dateigroesse = c.Double(nullable: false),
                        Dateityp = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DriveContents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.DriveObjekts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UUID = c.String(),
                        Name = c.String(),
                        Erstelldatum = c.DateTime(nullable: false),
                        Aenderungsdatum = c.DateTime(nullable: false),
                        Aktiv = c.Boolean(nullable: false),
                        DateiEigenschaften_Id = c.Int(),
                        OrdnerEigenschaften_Id = c.Int(),
                        ParentOrdner_Id = c.Int(),
                        DriveContent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dateis", t => t.DateiEigenschaften_Id, cascadeDelete: true)
                .ForeignKey("dbo.Ordners", t => t.OrdnerEigenschaften_Id, cascadeDelete: true)
                .ForeignKey("dbo.Ordners", t => t.ParentOrdner_Id)
                .ForeignKey("dbo.DriveContents", t => t.DriveContent_Id)
                .Index(t => t.DateiEigenschaften_Id)
                .Index(t => t.OrdnerEigenschaften_Id)
                .Index(t => t.ParentOrdner_Id)
                .Index(t => t.DriveContent_Id);
            
            CreateTable(
                "dbo.Ordners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DriveObjekt_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DriveObjekts", t => t.DriveObjekt_Id)
                .Index(t => t.DriveObjekt_Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vorname = c.String(),
                        Nachname = c.String(),
                        Email = c.String(),
                        Passwort = c.String(),
                        DowniePunkte = c.Int(nullable: false),
                        Beschreibung = c.String(),
                        Geschlecht = c.Boolean(nullable: false),
                        Level = c.Int(nullable: false),
                        Erstelldatum = c.DateTime(nullable: false),
                        Aenderungsdatum = c.DateTime(nullable: false),
                        Aktiv = c.Boolean(nullable: false),
                        Benutzerrolle_Id = c.Int(),
                        LevelFarbe_Id = c.Int(),
                        ProfilBild_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Benutzerrolles", t => t.Benutzerrolle_Id)
                .ForeignKey("dbo.LevelFarbes", t => t.LevelFarbe_Id)
                .ForeignKey("dbo.ProfilBilds", t => t.ProfilBild_Id)
                .Index(t => t.Benutzerrolle_Id)
                .Index(t => t.LevelFarbe_Id)
                .Index(t => t.ProfilBild_Id);
            
            CreateTable(
                "dbo.LevelFarbes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Beschreibung = c.String(),
                        LevelAnforderung = c.Int(nullable: false),
                        Erstelldatum = c.DateTime(nullable: false),
                        Aenderungsdatum = c.DateTime(nullable: false),
                        Aktiv = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfilBilds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Daten = c.Binary(),
                        Erstelldatum = c.DateTime(nullable: false),
                        Aenderungsdatum = c.DateTime(nullable: false),
                        Aktiv = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "ProfilBild_Id", "dbo.ProfilBilds");
            DropForeignKey("dbo.People", "LevelFarbe_Id", "dbo.LevelFarbes");
            DropForeignKey("dbo.DriveContents", "Person_Id", "dbo.People");
            DropForeignKey("dbo.People", "Benutzerrolle_Id", "dbo.Benutzerrolles");
            DropForeignKey("dbo.DriveObjekts", "DriveContent_Id", "dbo.DriveContents");
            DropForeignKey("dbo.DriveObjekts", "ParentOrdner_Id", "dbo.Ordners");
            DropForeignKey("dbo.DriveObjekts", "OrdnerEigenschaften_Id", "dbo.Ordners");
            DropForeignKey("dbo.Ordners", "DriveObjekt_Id", "dbo.DriveObjekts");
            DropForeignKey("dbo.DriveObjekts", "DateiEigenschaften_Id", "dbo.Dateis");
            DropIndex("dbo.People", new[] { "ProfilBild_Id" });
            DropIndex("dbo.People", new[] { "LevelFarbe_Id" });
            DropIndex("dbo.People", new[] { "Benutzerrolle_Id" });
            DropIndex("dbo.Ordners", new[] { "DriveObjekt_Id" });
            DropIndex("dbo.DriveObjekts", new[] { "DriveContent_Id" });
            DropIndex("dbo.DriveObjekts", new[] { "ParentOrdner_Id" });
            DropIndex("dbo.DriveObjekts", new[] { "OrdnerEigenschaften_Id" });
            DropIndex("dbo.DriveObjekts", new[] { "DateiEigenschaften_Id" });
            DropIndex("dbo.DriveContents", new[] { "Person_Id" });
            DropTable("dbo.ProfilBilds");
            DropTable("dbo.LevelFarbes");
            DropTable("dbo.People");
            DropTable("dbo.Ordners");
            DropTable("dbo.DriveObjekts");
            DropTable("dbo.DriveContents");
            DropTable("dbo.Dateis");
            DropTable("dbo.Benutzerrolles");
        }
    }
}

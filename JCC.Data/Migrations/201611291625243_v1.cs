namespace JCC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cinemas",
                c => new
                    {
                        CinemaId = c.Int(nullable: false, identity: true),
                        nom = c.String(),
                        localisation = c.String(),
                    })
                .PrimaryKey(t => t.CinemaId);
            
            CreateTable(
                "dbo.Projections",
                c => new
                    {
                        ProjectionId = c.Int(nullable: false, identity: true),
                        horaire = c.DateTime(nullable: false),
                        CinemaId = c.Int(),
                        FilmId = c.Int(),
                    })
                .PrimaryKey(t => t.ProjectionId)
                .ForeignKey("dbo.Films", t => t.FilmId)
                .ForeignKey("dbo.cinemas", t => t.CinemaId)
                .Index(t => t.CinemaId)
                .Index(t => t.FilmId);
            
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        FilmId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        realisateur = c.String(),
                        origine = c.String(),
                    })
                .PrimaryKey(t => t.FilmId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        ProjectionId = c.Int(),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Projections", t => t.ProjectionId)
                .Index(t => t.ProjectionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projections", "CinemaId", "dbo.cinemas");
            DropForeignKey("dbo.Tickets", "ProjectionId", "dbo.Projections");
            DropForeignKey("dbo.Projections", "FilmId", "dbo.Films");
            DropIndex("dbo.Tickets", new[] { "ProjectionId" });
            DropIndex("dbo.Projections", new[] { "FilmId" });
            DropIndex("dbo.Projections", new[] { "CinemaId" });
            DropTable("dbo.Tickets");
            DropTable("dbo.Films");
            DropTable("dbo.Projections");
            DropTable("dbo.cinemas");
        }
    }
}

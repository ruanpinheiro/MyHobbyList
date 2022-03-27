namespace MyHobbyListProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        BirthDay = c.DateTime(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Animes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassificationAnime = c.Int(nullable: false),
                        Name = c.String(),
                        Resume = c.String(),
                        EnumStatus = c.Int(nullable: false),
                        EnumScore = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassificationFilm = c.Int(nullable: false),
                        Name = c.String(),
                        Resume = c.String(),
                        EnumStatus = c.Int(nullable: false),
                        EnumScore = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Series",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassificationSerie = c.Int(nullable: false),
                        Name = c.String(),
                        Resume = c.String(),
                        EnumStatus = c.Int(nullable: false),
                        EnumScore = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Series", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Films", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Animes", "User_Id", "dbo.Users");
            DropIndex("dbo.Series", new[] { "User_Id" });
            DropIndex("dbo.Films", new[] { "User_Id" });
            DropIndex("dbo.Animes", new[] { "User_Id" });
            DropTable("dbo.Series");
            DropTable("dbo.Films");
            DropTable("dbo.Animes");
            DropTable("dbo.Users");
        }
    }
}

namespace MyHobbyListProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Animes", "QtdEpisodes", c => c.Int(nullable: false));
            AddColumn("dbo.Series", "QtdEpisodes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Series", "QtdEpisodes");
            DropColumn("dbo.Animes", "QtdEpisodes");
        }
    }
}

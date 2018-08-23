namespace PlaystationStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PS4_games",
                c => new
                    {
                        gameID = c.Int(nullable: false, identity: true),
                        gameName = c.String(),
                        gameGeneric = c.String(),
                        gamePrice = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.gameID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PS4_games");
        }
    }
}

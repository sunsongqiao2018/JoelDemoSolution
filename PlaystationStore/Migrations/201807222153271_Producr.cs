namespace PlaystationStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Producr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        producerId = c.Int(nullable: false, identity: true),
                        producerName = c.String(nullable: false, maxLength: 100),
                        producerType = c.String(),
                    })
                .PrimaryKey(t => t.producerId);
            
            AddColumn("dbo.PS4_games", "producer_producerId", c => c.Int());
            CreateIndex("dbo.PS4_games", "producer_producerId");
            AddForeignKey("dbo.PS4_games", "producer_producerId", "dbo.Producers", "producerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PS4_games", "producer_producerId", "dbo.Producers");
            DropIndex("dbo.PS4_games", new[] { "producer_producerId" });
            DropColumn("dbo.PS4_games", "producer_producerId");
            DropTable("dbo.Producers");
        }
    }
}

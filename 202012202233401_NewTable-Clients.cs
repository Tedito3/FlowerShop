namespace FlowerShop3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableClients : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 10),
                        FamilyName = c.String(maxLength: 10),
                        Address = c.String(maxLength: 30),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TakeDate = c.DateTime(nullable: false),
                        ClientId = c.Int(nullable: false),
                        FlowerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Flowers", t => t.FlowerId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.FlowerId);
            
            CreateTable(
                "dbo.Flowers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlowerName = c.String(maxLength: 10),
                        FlowerColour = c.String(maxLength: 10),
                        FlowerAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "FlowerId", "dbo.Flowers");
            DropForeignKey("dbo.Sales", "ClientId", "dbo.Clients");
            DropIndex("dbo.Sales", new[] { "FlowerId" });
            DropIndex("dbo.Sales", new[] { "ClientId" });
            DropTable("dbo.Flowers");
            DropTable("dbo.Sales");
            DropTable("dbo.Clients");
        }
    }
}

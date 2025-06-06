namespace Proekt_magazin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fruits",
                c => new
                    {
                        NumberId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeNumberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NumberId)
                .ForeignKey("dbo.FruitTypes", t => t.TypeNumberId, cascadeDelete: true)
                .Index(t => t.TypeNumberId);
            
            CreateTable(
                "dbo.FruitTypes",
                c => new
                    {
                        TypeNumberId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.TypeNumberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fruits", "TypeNumberId", "dbo.FruitTypes");
            DropIndex("dbo.Fruits", new[] { "TypeNumberId" });
            DropTable("dbo.FruitTypes");
            DropTable("dbo.Fruits");
        }
    }
}

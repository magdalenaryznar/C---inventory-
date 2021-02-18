namespace Inventory.WPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductQuantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name_Id = c.Int(),
                        ProductTax_Id = c.Int(),
                        ProductUnit_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductNames", t => t.Name_Id)
                .ForeignKey("dbo.ProductTaxes", t => t.ProductTax_Id)
                .ForeignKey("dbo.Units", t => t.ProductUnit_Id)
                .Index(t => t.Name_Id)
                .Index(t => t.ProductTax_Id)
                .Index(t => t.ProductUnit_Id);
            
            CreateTable(
                "dbo.ProductTaxes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amout = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductUnit_Id", "dbo.Units");
            DropForeignKey("dbo.Products", "ProductTax_Id", "dbo.ProductTaxes");
            DropForeignKey("dbo.Products", "Name_Id", "dbo.ProductNames");
            DropIndex("dbo.Products", new[] { "ProductUnit_Id" });
            DropIndex("dbo.Products", new[] { "ProductTax_Id" });
            DropIndex("dbo.Products", new[] { "Name_Id" });
            DropTable("dbo.Units");
            DropTable("dbo.ProductTaxes");
            DropTable("dbo.Products");
            DropTable("dbo.ProductNames");
        }
    }
}

namespace ksc_matsushita_webapi1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Employees", "RegionID", "dbo.Regions");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Products", "ProductCategoryID", "dbo.ProductCategories");
            DropForeignKey("dbo.Suppliers", "RegionID", "dbo.Regions");
            DropForeignKey("dbo.Products", "SupplierID", "dbo.Suppliers");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropIndex("dbo.Customers", new[] { "RegionId" });
            DropIndex("dbo.Employees", new[] { "RegionID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.Products", new[] { "SupplierID" });
            DropIndex("dbo.Products", new[] { "ProductCategoryID" });
            DropIndex("dbo.Suppliers", new[] { "RegionID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Suppliers", "RegionID");
            CreateIndex("dbo.Products", "ProductCategoryID");
            CreateIndex("dbo.Products", "SupplierID");
            CreateIndex("dbo.OrderDetails", "ProductID");
            CreateIndex("dbo.OrderDetails", "OrderID");
            CreateIndex("dbo.Employees", "RegionID");
            CreateIndex("dbo.Customers", "RegionId");
            AddForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products", "ProductID");
            AddForeignKey("dbo.Products", "SupplierID", "dbo.Suppliers", "SupplierID");
            AddForeignKey("dbo.Suppliers", "RegionID", "dbo.Regions", "RegionID");
            AddForeignKey("dbo.Products", "ProductCategoryID", "dbo.ProductCategories", "ProductCategoryID");
            AddForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders", "OrderID");
            AddForeignKey("dbo.Employees", "RegionID", "dbo.Regions", "RegionID");
            AddForeignKey("dbo.Customers", "RegionId", "dbo.Regions", "RegionID");
        }
    }
}

namespace ksc_matsushita_webapi1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calendars",
                c => new
                    {
                        Date = c.DateTime(nullable: false),
                        Year = c.String(maxLength: 4),
                        Quarter = c.String(maxLength: 2),
                        Month = c.String(maxLength: 2),
                    })
                .PrimaryKey(t => t.Date);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CompanyNameKana = c.String(maxLength: 40),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        ContactName = c.String(maxLength: 30),
                        ContactDepartment = c.String(maxLength: 30),
                        PostalCode = c.String(maxLength: 10),
                        RegionId = c.Int(),
                        Address1 = c.String(maxLength: 60),
                        Address2 = c.String(maxLength: 60),
                        Phone = c.String(maxLength: 24),
                        Fax = c.String(maxLength: 24),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.Regions", t => t.RegionId)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        RegionID = c.Int(nullable: false, identity: true),
                        RegionName = c.String(nullable: false, maxLength: 15),
                        RegionNameKana = c.String(maxLength: 30),
                        RegionNameE = c.String(maxLength: 100),
                        AreaName = c.String(maxLength: 10),
                        AreaNameE = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.RegionID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeNameKana = c.String(maxLength: 80),
                        EmployeeName = c.String(nullable: false, maxLength: 40),
                        BranchName = c.String(maxLength: 20),
                        DepartmentName = c.String(maxLength: 30),
                        BirthDate = c.DateTime(),
                        HireDate = c.DateTime(),
                        PostalCode = c.String(maxLength: 10),
                        RegionID = c.Int(),
                        Address1 = c.String(maxLength: 60),
                        Address2 = c.String(maxLength: 60),
                        Phone = c.String(maxLength: 24),
                        Extension = c.String(maxLength: 4),
                        PhotoPath = c.String(maxLength: 255),
                        Profile = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Regions", t => t.RegionID)
                .Index(t => t.RegionID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        DetailNo = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        UnitPrice = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Discount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.DetailNo })
                .ForeignKey("dbo.Orders", t => t.OrderID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(),
                        EmployeeID = c.Int(),
                        ShipName = c.String(maxLength: 40),
                        ShipPostalCode = c.String(maxLength: 10),
                        ShipRegionID = c.Int(),
                        ShipAddress1 = c.String(maxLength: 60),
                        ShipAddress2 = c.String(maxLength: 60),
                        ShipperID = c.Int(),
                        OrderDate = c.DateTime(),
                        RequiredDate = c.DateTime(),
                        ShippedDate = c.DateTime(),
                        ShipVia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .ForeignKey("dbo.Calendars", t => t.OrderDate)
                .ForeignKey("dbo.Regions", t => t.ShipRegionID)
                .ForeignKey("dbo.Calendars", t => t.RequiredDate)
                .ForeignKey("dbo.Calendars", t => t.ShippedDate)
                .ForeignKey("dbo.Shippers", t => t.ShipperID)
                .Index(t => t.CustomerID)
                .Index(t => t.EmployeeID)
                .Index(t => t.ShipRegionID)
                .Index(t => t.ShipperID)
                .Index(t => t.OrderDate)
                .Index(t => t.RequiredDate)
                .Index(t => t.ShippedDate);
            
            CreateTable(
                "dbo.Shippers",
                c => new
                    {
                        ShipperID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        Phone = c.String(nullable: false, maxLength: 24),
                    })
                .PrimaryKey(t => t.ShipperID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductNameKana = c.String(maxLength: 80),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        SupplierID = c.Int(),
                        ProductCategoryID = c.Int(),
                        QuantityPerUnit = c.String(maxLength: 20),
                        UnitPrice = c.Int(nullable: false),
                        UnitsInStock = c.Int(nullable: false),
                        UnitsOnOrder = c.Int(nullable: false),
                        ReorderLevel = c.Int(nullable: false),
                        Discontinued = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategoryID)
                .ForeignKey("dbo.Suppliers", t => t.SupplierID)
                .Index(t => t.SupplierID)
                .Index(t => t.ProductCategoryID);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ProductCategoryID = c.Int(nullable: false, identity: true),
                        ProductCategoryName = c.String(nullable: false, maxLength: 30),
                        Description = c.String(),
                        Picture = c.Binary(),
                    })
                .PrimaryKey(t => t.ProductCategoryID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierID = c.Int(nullable: false, identity: true),
                        CompanyNameKana = c.String(maxLength: 80),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        ContactName = c.String(maxLength: 30),
                        ContactDepartment = c.String(maxLength: 30),
                        PostalCode = c.String(maxLength: 10),
                        RegionID = c.Int(),
                        Address1 = c.String(maxLength: 60),
                        Address2 = c.String(maxLength: 60),
                        Phone = c.String(maxLength: 24),
                        Fax = c.String(maxLength: 24),
                        HomePage = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.SupplierID)
                .ForeignKey("dbo.Regions", t => t.RegionID)
                .Index(t => t.RegionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "SupplierID", "dbo.Suppliers");
            DropForeignKey("dbo.Suppliers", "RegionID", "dbo.Regions");
            DropForeignKey("dbo.Products", "ProductCategoryID", "dbo.ProductCategories");
            DropForeignKey("dbo.Orders", "ShipperID", "dbo.Shippers");
            DropForeignKey("dbo.Orders", "ShippedDate", "dbo.Calendars");
            DropForeignKey("dbo.Orders", "RequiredDate", "dbo.Calendars");
            DropForeignKey("dbo.Orders", "ShipRegionID", "dbo.Regions");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "OrderDate", "dbo.Calendars");
            DropForeignKey("dbo.Orders", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Employees", "RegionID", "dbo.Regions");
            DropForeignKey("dbo.Customers", "RegionId", "dbo.Regions");
            DropIndex("dbo.Suppliers", new[] { "RegionID" });
            DropIndex("dbo.Products", new[] { "ProductCategoryID" });
            DropIndex("dbo.Products", new[] { "SupplierID" });
            DropIndex("dbo.Orders", new[] { "ShippedDate" });
            DropIndex("dbo.Orders", new[] { "RequiredDate" });
            DropIndex("dbo.Orders", new[] { "OrderDate" });
            DropIndex("dbo.Orders", new[] { "ShipperID" });
            DropIndex("dbo.Orders", new[] { "ShipRegionID" });
            DropIndex("dbo.Orders", new[] { "EmployeeID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Employees", new[] { "RegionID" });
            DropIndex("dbo.Customers", new[] { "RegionId" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Shippers");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Employees");
            DropTable("dbo.Regions");
            DropTable("dbo.Customers");
            DropTable("dbo.Calendars");
        }
    }
}

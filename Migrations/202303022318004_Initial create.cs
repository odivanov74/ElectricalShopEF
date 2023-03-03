namespace ElectricalDevicesEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Salt = c.String(),
                        Role = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        PersonalDiscount = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateOfSale = c.DateTime(nullable: false),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SerialNumber = c.String(),
                        ManufactureDate = c.DateTime(nullable: false),
                        isDefected = c.Boolean(nullable: false),
                        Basket_Id = c.Int(),
                        ModelDevice_Id = c.Int(),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Baskets", t => t.Basket_Id)
                .ForeignKey("dbo.ModelDevices", t => t.ModelDevice_Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Basket_Id)
                .Index(t => t.ModelDevice_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.ModelDevices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Weight = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StockBalance = c.Int(nullable: false),
                        Reserved = c.Int(nullable: false),
                        Manufacturer_Id = c.Int(),
                        Supplier_Id = c.Int(),
                        TypeModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_Id)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_Id)
                .ForeignKey("dbo.TypeModels", t => t.TypeModel_Id)
                .Index(t => t.Manufacturer_Id)
                .Index(t => t.Supplier_Id)
                .Index(t => t.TypeModel_Id);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Managers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Directors", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Clients", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Devices", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Devices", "ModelDevice_Id", "dbo.ModelDevices");
            DropForeignKey("dbo.ModelDevices", "TypeModel_Id", "dbo.TypeModels");
            DropForeignKey("dbo.ModelDevices", "Supplier_Id", "dbo.Suppliers");
            DropForeignKey("dbo.ModelDevices", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.Manufacturers", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Devices", "Basket_Id", "dbo.Baskets");
            DropForeignKey("dbo.Orders", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Baskets", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Admins", "User_Id", "dbo.Users");
            DropIndex("dbo.Managers", new[] { "User_Id" });
            DropIndex("dbo.Directors", new[] { "User_Id" });
            DropIndex("dbo.Manufacturers", new[] { "Country_Id" });
            DropIndex("dbo.ModelDevices", new[] { "TypeModel_Id" });
            DropIndex("dbo.ModelDevices", new[] { "Supplier_Id" });
            DropIndex("dbo.ModelDevices", new[] { "Manufacturer_Id" });
            DropIndex("dbo.Devices", new[] { "Order_Id" });
            DropIndex("dbo.Devices", new[] { "ModelDevice_Id" });
            DropIndex("dbo.Devices", new[] { "Basket_Id" });
            DropIndex("dbo.Orders", new[] { "Client_Id" });
            DropIndex("dbo.Clients", new[] { "User_Id" });
            DropIndex("dbo.Baskets", new[] { "Client_Id" });
            DropIndex("dbo.Admins", new[] { "User_Id" });
            DropTable("dbo.Managers");
            DropTable("dbo.Directors");
            DropTable("dbo.TypeModels");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Countries");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.ModelDevices");
            DropTable("dbo.Devices");
            DropTable("dbo.Orders");
            DropTable("dbo.Clients");
            DropTable("dbo.Baskets");
            DropTable("dbo.Users");
            DropTable("dbo.Admins");
        }
    }
}

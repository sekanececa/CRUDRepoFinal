namespace CRUDtest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Address : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Employee_EmployeeID", "dbo.Employees");
            DropIndex("dbo.Employees", new[] { "Employee_EmployeeID" });
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        Type = c.String(),
                        EmployeeAddress = c.String(),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID);
            
            DropColumn("dbo.Employees", "Employee_EmployeeID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Employee_EmployeeID", c => c.Int());
            DropForeignKey("dbo.Addresses", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.Addresses", new[] { "EmployeeID" });
            DropTable("dbo.Addresses");
            CreateIndex("dbo.Employees", "Employee_EmployeeID");
            AddForeignKey("dbo.Employees", "Employee_EmployeeID", "dbo.Employees", "EmployeeID");
        }
    }
}

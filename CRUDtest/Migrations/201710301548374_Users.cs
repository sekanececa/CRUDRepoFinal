namespace CRUDtest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Users : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UsersId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Employee_EmployeeID = c.Int(),
                    })
                .PrimaryKey(t => t.UsersId)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeID)
                .Index(t => t.Employee_EmployeeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Employee_EmployeeID", "dbo.Employees");
            DropIndex("dbo.Users", new[] { "Employee_EmployeeID" });
            DropTable("dbo.Users");
        }
    }
}

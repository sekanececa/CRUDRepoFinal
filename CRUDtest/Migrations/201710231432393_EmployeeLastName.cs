namespace CRUDtest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeLastName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmployeeLastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "EmployeeLastName");
        }
    }
}

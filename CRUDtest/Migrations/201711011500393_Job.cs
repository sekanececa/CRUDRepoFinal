namespace CRUDtest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Job : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Job", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Job");
        }
    }
}

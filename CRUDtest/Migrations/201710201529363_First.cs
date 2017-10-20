namespace CRUDtest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Town", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Town");
        }
    }
}

namespace CRUDtest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        Designation = c.String(),
                        ManagerID = c.Int(),
                        ContactNo = c.String(),
                        EMailID = c.String(),
                        SkillSets = c.String(),
                        Town = c.String(),
                        Employee_EmployeeID = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeID)
                .Index(t => t.Employee_EmployeeID);
            
            CreateTable(
                "dbo.ProjectTasks",
                c => new
                    {
                        ProjectTaskID = c.Int(nullable: false, identity: true),
                        AssignedTo = c.Int(),
                        TaskStartDate = c.DateTime(),
                        TaskEndDate = c.DateTime(),
                        TaskCompletion = c.Int(),
                        UserStoryID = c.Int(),
                        Employee_EmployeeID = c.Int(),
                    })
                .PrimaryKey(t => t.ProjectTaskID)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeID)
                .ForeignKey("dbo.UserStories", t => t.UserStoryID)
                .Index(t => t.UserStoryID)
                .Index(t => t.Employee_EmployeeID);
            
            CreateTable(
                "dbo.ManagerComments",
                c => new
                    {
                        ManagerCommentID = c.Int(nullable: false, identity: true),
                        Comments = c.String(),
                        ProjectTaskID = c.Int(),
                    })
                .PrimaryKey(t => t.ManagerCommentID)
                .ForeignKey("dbo.ProjectTasks", t => t.ProjectTaskID)
                .Index(t => t.ProjectTaskID);
            
            CreateTable(
                "dbo.UserStories",
                c => new
                    {
                        UserStoryID = c.Int(nullable: false, identity: true),
                        Story = c.String(),
                        ProjectID = c.Int(),
                    })
                .PrimaryKey(t => t.UserStoryID)
                .ForeignKey("dbo.Projects", t => t.ProjectID)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        ClientName = c.String(),
                    })
                .PrimaryKey(t => t.ProjectID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectTasks", "UserStoryID", "dbo.UserStories");
            DropForeignKey("dbo.UserStories", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ManagerComments", "ProjectTaskID", "dbo.ProjectTasks");
            DropForeignKey("dbo.ProjectTasks", "Employee_EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Employee_EmployeeID", "dbo.Employees");
            DropIndex("dbo.UserStories", new[] { "ProjectID" });
            DropIndex("dbo.ManagerComments", new[] { "ProjectTaskID" });
            DropIndex("dbo.ProjectTasks", new[] { "Employee_EmployeeID" });
            DropIndex("dbo.ProjectTasks", new[] { "UserStoryID" });
            DropIndex("dbo.Employees", new[] { "Employee_EmployeeID" });
            DropTable("dbo.Projects");
            DropTable("dbo.UserStories");
            DropTable("dbo.ManagerComments");
            DropTable("dbo.ProjectTasks");
            DropTable("dbo.Employees");
        }
    }
}

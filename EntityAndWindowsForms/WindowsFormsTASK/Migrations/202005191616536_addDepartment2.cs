namespace WindowsFormsTASK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDepartment2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "department_Id", "dbo.Departments");
            DropIndex("dbo.Users", new[] { "department_Id" });
            RenameColumn(table: "dbo.Users", name: "department_Id", newName: "departmentId");
            AlterColumn("dbo.Users", "occupation", c => c.String(maxLength: 50));
            AlterColumn("dbo.Users", "departmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "departmentId");
            AddForeignKey("dbo.Users", "departmentId", "dbo.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "departmentId", "dbo.Departments");
            DropIndex("dbo.Users", new[] { "departmentId" });
            AlterColumn("dbo.Users", "departmentId", c => c.Int());
            AlterColumn("dbo.Users", "occupation", c => c.String());
            RenameColumn(table: "dbo.Users", name: "departmentId", newName: "department_Id");
            CreateIndex("dbo.Users", "department_Id");
            AddForeignKey("dbo.Users", "department_Id", "dbo.Departments", "Id");
        }
    }
}

namespace WindowsFormsTASK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class department : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "department", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "department");
        }
    }
}

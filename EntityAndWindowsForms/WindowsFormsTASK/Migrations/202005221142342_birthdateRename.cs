namespace WindowsFormsTASK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class birthdateRename : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "birthData", c => c.DateTime(nullable: false));
            DropColumn("dbo.Users", "bornData");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "bornData", c => c.DateTime(nullable: false));
            DropColumn("dbo.Users", "birthData");
        }
    }
}

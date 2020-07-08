namespace WindowsFormsTASK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personNum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "personNum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "personNum");
        }
    }
}

namespace WindowsFormsTASK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class occupation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "occupation", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "occupation", c => c.Int(nullable: false));
        }
    }
}

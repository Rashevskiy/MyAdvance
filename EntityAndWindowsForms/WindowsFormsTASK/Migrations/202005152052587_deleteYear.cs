namespace WindowsFormsTASK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteYear : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Markers", "year");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Markers", "year", c => c.Int(nullable: false));
        }
    }
}

namespace WindowsFormsTASK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        firstName = c.String(maxLength: 50),
                        secondName = c.String(maxLength: 50),
                        bornData = c.DateTime(nullable: false),
                        age = c.Int(nullable: false),
                        occupation = c.Int(nullable: false),
                        remoteWork = c.Boolean(nullable: false),
                        address = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}

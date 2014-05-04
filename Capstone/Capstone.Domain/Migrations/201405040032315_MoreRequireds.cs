namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreRequireds : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserFName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "UserLName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserLName", c => c.String());
            AlterColumn("dbo.Users", "UserFName", c => c.String());
        }
    }
}

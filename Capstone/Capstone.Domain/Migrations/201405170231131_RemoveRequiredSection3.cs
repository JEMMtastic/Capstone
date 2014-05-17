namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRequiredSection3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Forms", "Notes", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Forms", "Notes", c => c.String(nullable: false));
        }
    }
}

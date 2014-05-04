namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserRequireds : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "BvLocation_BvLocationId", "dbo.BvLocations");
            DropIndex("dbo.Users", new[] { "BvLocation_BvLocationId" });
            AlterColumn("dbo.Users", "BvLocation_BvLocationId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "BvLocation_BvLocationId");
            AddForeignKey("dbo.Users", "BvLocation_BvLocationId", "dbo.BvLocations", "BvLocationId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "BvLocation_BvLocationId", "dbo.BvLocations");
            DropIndex("dbo.Users", new[] { "BvLocation_BvLocationId" });
            AlterColumn("dbo.Users", "BvLocation_BvLocationId", c => c.Int());
            CreateIndex("dbo.Users", "BvLocation_BvLocationId");
            AddForeignKey("dbo.Users", "BvLocation_BvLocationId", "dbo.BvLocations", "BvLocationId");
        }
    }
}

namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sillyMichelle : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.StatsInfoes", new[] { "partnershipNight_PartnershipNightId" });
            //AlterColumn("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", c => c.Int(nullable: false));
            CreateIndex("dbo.StatsInfoes", "partnershipNight_PartnershipNightId");
            AddForeignKey("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights", "PartnershipNightId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.StatsInfoes", new[] { "partnershipNight_PartnershipNightId" });
            //AlterColumn("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", c => c.Int());
            CreateIndex("dbo.StatsInfoes", "partnershipNight_PartnershipNightId");
            AddForeignKey("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights", "PartnershipNightId");
        }
    }
}

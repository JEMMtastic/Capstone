namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPnObjToStat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", c => c.Int());
            CreateIndex("dbo.StatsInfoes", "partnershipNight_PartnershipNightId");
            AddForeignKey("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights", "PartnershipNightId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.StatsInfoes", new[] { "partnershipNight_PartnershipNightId" });
            DropColumn("dbo.StatsInfoes", "partnershipNight_PartnershipNightId");
        }
    }
}

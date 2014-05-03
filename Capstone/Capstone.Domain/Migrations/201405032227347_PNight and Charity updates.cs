namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PNightandCharityupdates : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PartnershipNights", "BVLocation_BvLocationId", "dbo.BvLocations");
            DropForeignKey("dbo.PartnershipNights", "Charity_CharityId", "dbo.Charities");
            DropForeignKey("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.PartnershipNights", new[] { "BVLocation_BvLocationId" });
            DropIndex("dbo.PartnershipNights", new[] { "Charity_CharityId" });
            DropIndex("dbo.StatsInfoes", new[] { "partnershipNight_PartnershipNightId" });
            AlterColumn("dbo.Charities", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Charities", "Zip", c => c.String(nullable: false));
            AlterColumn("dbo.Charities", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Charities", "FederalTaxId", c => c.String(nullable: false));
            AlterColumn("dbo.PartnershipNights", "BVLocation_BvLocationId", c => c.Int(nullable: false));
            AlterColumn("dbo.PartnershipNights", "Charity_CharityId", c => c.Int(nullable: false));
            AlterColumn("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", c => c.Int());
            CreateIndex("dbo.PartnershipNights", "BVLocation_BvLocationId");
            CreateIndex("dbo.PartnershipNights", "Charity_CharityId");
            CreateIndex("dbo.StatsInfoes", "partnershipNight_PartnershipNightId");
            AddForeignKey("dbo.PartnershipNights", "BVLocation_BvLocationId", "dbo.BvLocations", "BvLocationId", cascadeDelete: true);
            AddForeignKey("dbo.PartnershipNights", "Charity_CharityId", "dbo.Charities", "CharityId", cascadeDelete: true);
            AddForeignKey("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights", "PartnershipNightId");
            DropColumn("dbo.PartnershipNights", "AmountRaised");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PartnershipNights", "AmountRaised", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights");
            DropForeignKey("dbo.PartnershipNights", "Charity_CharityId", "dbo.Charities");
            DropForeignKey("dbo.PartnershipNights", "BVLocation_BvLocationId", "dbo.BvLocations");
            DropIndex("dbo.StatsInfoes", new[] { "partnershipNight_PartnershipNightId" });
            DropIndex("dbo.PartnershipNights", new[] { "Charity_CharityId" });
            DropIndex("dbo.PartnershipNights", new[] { "BVLocation_BvLocationId" });
            AlterColumn("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", c => c.Int(nullable: false));
            AlterColumn("dbo.PartnershipNights", "Charity_CharityId", c => c.Int());
            AlterColumn("dbo.PartnershipNights", "BVLocation_BvLocationId", c => c.Int());
            AlterColumn("dbo.Charities", "FederalTaxId", c => c.String());
            AlterColumn("dbo.Charities", "Phone", c => c.String());
            AlterColumn("dbo.Charities", "Zip", c => c.String());
            AlterColumn("dbo.Charities", "Name", c => c.String());
            CreateIndex("dbo.StatsInfoes", "partnershipNight_PartnershipNightId");
            CreateIndex("dbo.PartnershipNights", "Charity_CharityId");
            CreateIndex("dbo.PartnershipNights", "BVLocation_BvLocationId");
            AddForeignKey("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights", "PartnershipNightId", cascadeDelete: true);
            AddForeignKey("dbo.PartnershipNights", "Charity_CharityId", "dbo.Charities", "CharityId");
            AddForeignKey("dbo.PartnershipNights", "BVLocation_BvLocationId", "dbo.BvLocations", "BvLocationId");
        }
    }
}

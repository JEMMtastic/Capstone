namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ByebyeStatsInfo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.StatsInfoes", new[] { "partnershipNight_PartnershipNightId" });
            CreateTable(
                "dbo.Section4",
                c => new
                    {
                        Section4Id = c.Int(nullable: false, identity: true),
                        TotalSales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AmountOfTotalSalesToCharity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CashDonations = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GuestCount = c.Int(nullable: false),
                        partnershipNight_PartnershipNightId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Section4Id)
                .ForeignKey("dbo.PartnershipNights", t => t.partnershipNight_PartnershipNightId, cascadeDelete: true)
                .Index(t => t.partnershipNight_PartnershipNightId);
            
            DropTable("dbo.StatsInfoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StatsInfoes",
                c => new
                    {
                        StatsInfoId = c.Int(nullable: false, identity: true),
                        TotalSales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AmountOfTotalSalesToCharity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CashDonations = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GuestCount = c.Int(nullable: false),
                        partnershipNight_PartnershipNightId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StatsInfoId);
            
            DropForeignKey("dbo.Section4", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.Section4", new[] { "partnershipNight_PartnershipNightId" });
            DropTable("dbo.Section4");
            CreateIndex("dbo.StatsInfoes", "partnershipNight_PartnershipNightId");
            AddForeignKey("dbo.StatsInfoes", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights", "PartnershipNightId", cascadeDelete: true);
        }
    }
}

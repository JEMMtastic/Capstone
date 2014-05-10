namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Section4Cleanup : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Section4", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.Section4", new[] { "partnershipNight_PartnershipNightId" });
            DropColumn("dbo.Section4", "TotalSales");
            DropColumn("dbo.Section4", "AmountOfTotalSalesToCharity");
            DropColumn("dbo.Section4", "CashDonations");
            DropColumn("dbo.Section4", "GuestCount");
            DropColumn("dbo.Section4", "partnershipNight_PartnershipNightId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Section4", "partnershipNight_PartnershipNightId", c => c.Int(nullable: false));
            AddColumn("dbo.Section4", "GuestCount", c => c.Int(nullable: false));
            AddColumn("dbo.Section4", "CashDonations", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Section4", "AmountOfTotalSalesToCharity", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Section4", "TotalSales", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            CreateIndex("dbo.Section4", "partnershipNight_PartnershipNightId");
            AddForeignKey("dbo.Section4", "partnershipNight_PartnershipNightId", "dbo.PartnershipNights", "PartnershipNightId", cascadeDelete: true);
        }
    }
}

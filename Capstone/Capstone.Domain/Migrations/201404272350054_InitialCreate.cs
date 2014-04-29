namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BvLocations",
                c => new
                    {
                        BvLocationId = c.Int(nullable: false, identity: true),
                        BvStoreNum = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Zip = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.BvLocationId);
            
            CreateTable(
                "dbo.Charities",
                c => new
                    {
                        CharityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Zip = c.String(),
                        Phone = c.String(),
                        FederalTaxId = c.String(),
                        TypeOfCharity = c.String(),
                    })
                .PrimaryKey(t => t.CharityId);
            
            CreateTable(
                "dbo.PartnershipNights",
                c => new
                    {
                        PartnershipNightId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        CheckRequestId = c.Int(nullable: false),
                        AmountRaised = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Comments = c.String(),
                        CheckRequestFinished = c.Boolean(nullable: false),
                        BeforeTheEventFinished = c.Boolean(nullable: false),
                        AfterTheEventFinished = c.Boolean(nullable: false),
                        BVLocation_BvLocationId = c.Int(),
                        Charity_CharityId = c.Int(),
                    })
                .PrimaryKey(t => t.PartnershipNightId)
                .ForeignKey("dbo.BvLocations", t => t.BVLocation_BvLocationId)
                .ForeignKey("dbo.Charities", t => t.Charity_CharityId)
                .Index(t => t.BVLocation_BvLocationId)
                .Index(t => t.Charity_CharityId);
            
            CreateTable(
                "dbo.StatsInfoes",
                c => new
                    {
                        StatsInfoId = c.Int(nullable: false, identity: true),
                        TotalSales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AmountOfTotalSalesToCharity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CashDonations = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GuestCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StatsInfoId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserFName = c.String(),
                        UserLName = c.String(),
                        Password = c.String(),
                        AccessLevel = c.Int(nullable: false),
                        UserEmail = c.String(),
                        PhoneNumber = c.String(),
                        BvLocation_BvLocationId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.BvLocations", t => t.BvLocation_BvLocationId)
                .Index(t => t.BvLocation_BvLocationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "BvLocation_BvLocationId", "dbo.BvLocations");
            DropForeignKey("dbo.PartnershipNights", "Charity_CharityId", "dbo.Charities");
            DropForeignKey("dbo.PartnershipNights", "BVLocation_BvLocationId", "dbo.BvLocations");
            DropIndex("dbo.Users", new[] { "BvLocation_BvLocationId" });
            DropIndex("dbo.PartnershipNights", new[] { "Charity_CharityId" });
            DropIndex("dbo.PartnershipNights", new[] { "BVLocation_BvLocationId" });
            DropTable("dbo.Users");
            DropTable("dbo.StatsInfoes");
            DropTable("dbo.PartnershipNights");
            DropTable("dbo.Charities");
            DropTable("dbo.BvLocations");
        }
    }
}

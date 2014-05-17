namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MergeSection3ToForm : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Section3", "PN_PartnershipNightId", "dbo.PartnershipNights");
            DropForeignKey("dbo.Section3", "pNight_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.Section3", new[] { "PN_PartnershipNightId" });
            DropIndex("dbo.Section3", new[] { "pNight_PartnershipNightId" });
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        FormId = c.Int(nullable: false, identity: true),
                        NewCharity = c.Boolean(nullable: false),
                        Purpose = c.String(),
                        Contact = c.String(),
                        Wk1FourGc = c.Int(nullable: false),
                        Wk1FiveGc = c.Int(nullable: false),
                        Wk1SixGc = c.Int(nullable: false),
                        Wk1SevenGc = c.Int(nullable: false),
                        Wk1EightGc = c.Int(nullable: false),
                        Wk2FourGc = c.Int(nullable: false),
                        Wk2FiveGc = c.Int(nullable: false),
                        Wk2SixGc = c.Int(nullable: false),
                        WkSevenGc = c.Int(nullable: false),
                        Wk2EightGc = c.Int(nullable: false),
                        Wk3FourGc = c.Int(nullable: false),
                        Wk3FiveGc = c.Int(nullable: false),
                        Wk3SixGc = c.Int(nullable: false),
                        Wk3SevenGc = c.Int(nullable: false),
                        Wk3EightGc = c.Int(nullable: false),
                        AvgChk4 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AvgChk5 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AvgChk6 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AvgChk7 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AVgChk8 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Hour4Sales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Hour5Sales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Hour6Sales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Hour7Sales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Hour8Sales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Hour4GC = c.Int(nullable: false),
                        Hour5GC = c.Int(nullable: false),
                        Hour6GC = c.Int(nullable: false),
                        Hour7GC = c.Int(nullable: false),
                        Hour8GC = c.Int(nullable: false),
                        PosiDonations = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Notes = c.String(nullable: false),
                        pNight_PartnershipNightId = c.Int(),
                    })
                .PrimaryKey(t => t.FormId)
                .ForeignKey("dbo.PartnershipNights", t => t.pNight_PartnershipNightId)
                .Index(t => t.pNight_PartnershipNightId);
            
            DropTable("dbo.Section3");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Section3",
                c => new
                    {
                        Section3Id = c.Int(nullable: false, identity: true),
                        NewCharity = c.Boolean(nullable: false),
                        Purpose = c.String(),
                        Contact = c.String(),
                        Wk1FourGc = c.Int(nullable: false),
                        Wk1FiveGc = c.Int(nullable: false),
                        Wk1SixGc = c.Int(nullable: false),
                        Wk1SevenGc = c.Int(nullable: false),
                        Wk1EightGc = c.Int(nullable: false),
                        Wk2FourGc = c.Int(nullable: false),
                        Wk2FiveGc = c.Int(nullable: false),
                        Wk2SixGc = c.Int(nullable: false),
                        WkSevenGc = c.Int(nullable: false),
                        Wk2EightGc = c.Int(nullable: false),
                        Wk3FourGc = c.Int(nullable: false),
                        Wk3FiveGc = c.Int(nullable: false),
                        Wk3SixGc = c.Int(nullable: false),
                        Wk3SevenGc = c.Int(nullable: false),
                        Wk3EightGc = c.Int(nullable: false),
                        AvgChk4 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AvgChk5 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AvgChk6 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AvgChk7 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AVgChk8 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Hour4Sales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Hour5Sales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Hour6Sales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Hour7Sales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Hour8Sales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Hour4GC = c.Int(nullable: false),
                        Hour5GC = c.Int(nullable: false),
                        Hour6GC = c.Int(nullable: false),
                        Hour7GC = c.Int(nullable: false),
                        Hour8GC = c.Int(nullable: false),
                        PosiDonations = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Notes = c.String(nullable: false),
                        PN_PartnershipNightId = c.Int(),
                        pNight_PartnershipNightId = c.Int(),
                    })
                .PrimaryKey(t => t.Section3Id);
            
            DropForeignKey("dbo.Forms", "pNight_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.Forms", new[] { "pNight_PartnershipNightId" });
            DropTable("dbo.Forms");
            CreateIndex("dbo.Section3", "pNight_PartnershipNightId");
            CreateIndex("dbo.Section3", "PN_PartnershipNightId");
            AddForeignKey("dbo.Section3", "pNight_PartnershipNightId", "dbo.PartnershipNights", "PartnershipNightId");
            AddForeignKey("dbo.Section3", "PN_PartnershipNightId", "dbo.PartnershipNights", "PartnershipNightId");
        }
    }
}

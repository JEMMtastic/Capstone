namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Section3domainmodeladded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Section3",
                c => new
                    {
                        Section3Id = c.Int(nullable: false, identity: true),
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
                .PrimaryKey(t => t.Section3Id)
                .ForeignKey("dbo.PartnershipNights", t => t.pNight_PartnershipNightId)
                .Index(t => t.pNight_PartnershipNightId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Section3", "pNight_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.Section3", new[] { "pNight_PartnershipNightId" });
            DropTable("dbo.Section3");
        }
    }
}

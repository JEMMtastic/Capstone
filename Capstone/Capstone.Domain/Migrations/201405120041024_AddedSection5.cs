namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSection5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Section5",
                c => new
                    {
                        Section5Id = c.Int(nullable: false, identity: true),
                        pNight_PartnershipNightId = c.Int(),
                    })
                .PrimaryKey(t => t.Section5Id)
                .ForeignKey("dbo.PartnershipNights", t => t.pNight_PartnershipNightId)
                .Index(t => t.pNight_PartnershipNightId);
            
            AddColumn("dbo.Section4", "pNight_PartnershipNightId", c => c.Int());
            AddColumn("dbo.Users", "Username", c => c.String(nullable: false));
            CreateIndex("dbo.Section4", "pNight_PartnershipNightId");
            AddForeignKey("dbo.Section4", "pNight_PartnershipNightId", "dbo.PartnershipNights", "PartnershipNightId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Section5", "pNight_PartnershipNightId", "dbo.PartnershipNights");
            DropForeignKey("dbo.Section4", "pNight_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.Section5", new[] { "pNight_PartnershipNightId" });
            DropIndex("dbo.Section4", new[] { "pNight_PartnershipNightId" });
            DropColumn("dbo.Users", "Username");
            DropColumn("dbo.Section4", "pNight_PartnershipNightId");
            DropTable("dbo.Section5");
        }
    }
}

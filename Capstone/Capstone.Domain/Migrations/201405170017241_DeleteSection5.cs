namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteSection5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Section5", "pNight_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.Section5", new[] { "pNight_PartnershipNightId" });
            DropTable("dbo.Section5");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Section5",
                c => new
                    {
                        Section5Id = c.Int(nullable: false, identity: true),
                        pNight_PartnershipNightId = c.Int(),
                    })
                .PrimaryKey(t => t.Section5Id);
            
            CreateIndex("dbo.Section5", "pNight_PartnershipNightId");
            AddForeignKey("dbo.Section5", "pNight_PartnershipNightId", "dbo.PartnershipNights", "PartnershipNightId");
        }
    }
}

namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteSection4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Section4", "pNight_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.Section4", new[] { "pNight_PartnershipNightId" });
            DropTable("dbo.Section4");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Section4",
                c => new
                    {
                        Section4Id = c.Int(nullable: false, identity: true),
                        pNight_PartnershipNightId = c.Int(),
                    })
                .PrimaryKey(t => t.Section4Id);
            
            CreateIndex("dbo.Section4", "pNight_PartnershipNightId");
            AddForeignKey("dbo.Section4", "pNight_PartnershipNightId", "dbo.PartnershipNights", "PartnershipNightId");
        }
    }
}

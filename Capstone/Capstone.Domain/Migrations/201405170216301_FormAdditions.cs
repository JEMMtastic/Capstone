namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FormAdditions : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Forms", "pNight_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.Forms", new[] { "pNight_PartnershipNightId" });
            AddColumn("dbo.Forms", "NewPartner", c => c.Boolean(nullable: false));
            AddColumn("dbo.Forms", "Wk1Year", c => c.Int(nullable: false));
            AddColumn("dbo.Forms", "Wk2Year", c => c.Int(nullable: false));
            AddColumn("dbo.Forms", "Wk3Year", c => c.Int(nullable: false));
            AddColumn("dbo.Forms", "LWkAvgChkFour", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "LWkAvgChkFive", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "LWkAvgChkSix", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "LWkAvgChkSeven", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "LWkAvgChkEight", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Forms", "NewCharity");
            DropColumn("dbo.Forms", "AvgChk4");
            DropColumn("dbo.Forms", "AvgChk5");
            DropColumn("dbo.Forms", "AvgChk6");
            DropColumn("dbo.Forms", "AvgChk7");
            DropColumn("dbo.Forms", "AVgChk8");
            DropColumn("dbo.Forms", "pNight_PartnershipNightId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Forms", "pNight_PartnershipNightId", c => c.Int());
            AddColumn("dbo.Forms", "AVgChk8", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "AvgChk7", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "AvgChk6", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "AvgChk5", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "AvgChk4", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "NewCharity", c => c.Boolean(nullable: false));
            DropColumn("dbo.Forms", "LWkAvgChkEight");
            DropColumn("dbo.Forms", "LWkAvgChkSeven");
            DropColumn("dbo.Forms", "LWkAvgChkSix");
            DropColumn("dbo.Forms", "LWkAvgChkFive");
            DropColumn("dbo.Forms", "LWkAvgChkFour");
            DropColumn("dbo.Forms", "Wk3Year");
            DropColumn("dbo.Forms", "Wk2Year");
            DropColumn("dbo.Forms", "Wk1Year");
            DropColumn("dbo.Forms", "NewPartner");
            CreateIndex("dbo.Forms", "pNight_PartnershipNightId");
            AddForeignKey("dbo.Forms", "pNight_PartnershipNightId", "dbo.PartnershipNights", "PartnershipNightId");
        }
    }
}

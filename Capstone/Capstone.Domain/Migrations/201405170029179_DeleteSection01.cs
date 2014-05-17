namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteSection01 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Section3", "NewCharity", c => c.Boolean(nullable: false));
            AddColumn("dbo.Section3", "Purpose", c => c.String());
            AddColumn("dbo.Section3", "Contact", c => c.String());
            AddColumn("dbo.Section3", "Wk1FourGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "Wk1FiveGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "Wk1SixGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "Wk1SevenGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "Wk1EightGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "Wk2FourGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "Wk2FiveGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "Wk2SixGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "WkSevenGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "Wk2EightGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "Wk3FourGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "Wk3FiveGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "Wk3SixGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "Wk3SevenGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "Wk3EightGc", c => c.Int(nullable: false));
            AddColumn("dbo.Section3", "AvgChk4", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Section3", "AvgChk5", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Section3", "AvgChk6", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Section3", "AvgChk7", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Section3", "AVgChk8", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Section3", "PN_PartnershipNightId", c => c.Int());
            CreateIndex("dbo.Section3", "PN_PartnershipNightId");
            AddForeignKey("dbo.Section3", "PN_PartnershipNightId", "dbo.PartnershipNights", "PartnershipNightId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Section3", "PN_PartnershipNightId", "dbo.PartnershipNights");
            DropIndex("dbo.Section3", new[] { "PN_PartnershipNightId" });
            DropColumn("dbo.Section3", "PN_PartnershipNightId");
            DropColumn("dbo.Section3", "AVgChk8");
            DropColumn("dbo.Section3", "AvgChk7");
            DropColumn("dbo.Section3", "AvgChk6");
            DropColumn("dbo.Section3", "AvgChk5");
            DropColumn("dbo.Section3", "AvgChk4");
            DropColumn("dbo.Section3", "Wk3EightGc");
            DropColumn("dbo.Section3", "Wk3SevenGc");
            DropColumn("dbo.Section3", "Wk3SixGc");
            DropColumn("dbo.Section3", "Wk3FiveGc");
            DropColumn("dbo.Section3", "Wk3FourGc");
            DropColumn("dbo.Section3", "Wk2EightGc");
            DropColumn("dbo.Section3", "WkSevenGc");
            DropColumn("dbo.Section3", "Wk2SixGc");
            DropColumn("dbo.Section3", "Wk2FiveGc");
            DropColumn("dbo.Section3", "Wk2FourGc");
            DropColumn("dbo.Section3", "Wk1EightGc");
            DropColumn("dbo.Section3", "Wk1SevenGc");
            DropColumn("dbo.Section3", "Wk1SixGc");
            DropColumn("dbo.Section3", "Wk1FiveGc");
            DropColumn("dbo.Section3", "Wk1FourGc");
            DropColumn("dbo.Section3", "Contact");
            DropColumn("dbo.Section3", "Purpose");
            DropColumn("dbo.Section3", "NewCharity");
        }
    }
}

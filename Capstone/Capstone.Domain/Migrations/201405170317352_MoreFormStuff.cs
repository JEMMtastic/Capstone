namespace Capstone.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreFormStuff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Forms", "Scenario1Gc", c => c.Int(nullable: false));
            AddColumn("dbo.Forms", "Scenario2Gc", c => c.Int(nullable: false));
            AddColumn("dbo.Forms", "ActualSalesFour", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "ActualSalesFive", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "ActualSalesSix", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "ActualSalesSeven", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "ActualSalesEight", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "ActualGcFour", c => c.Int(nullable: false));
            AddColumn("dbo.Forms", "ActualGcFive", c => c.Int(nullable: false));
            AddColumn("dbo.Forms", "ActualGcSix", c => c.Int(nullable: false));
            AddColumn("dbo.Forms", "ActualGcSeven", c => c.Int(nullable: false));
            AddColumn("dbo.Forms", "ActualGcEight", c => c.Int(nullable: false));
            DropColumn("dbo.Forms", "Hour4Sales");
            DropColumn("dbo.Forms", "Hour5Sales");
            DropColumn("dbo.Forms", "Hour6Sales");
            DropColumn("dbo.Forms", "Hour7Sales");
            DropColumn("dbo.Forms", "Hour8Sales");
            DropColumn("dbo.Forms", "Hour4GC");
            DropColumn("dbo.Forms", "Hour5GC");
            DropColumn("dbo.Forms", "Hour6GC");
            DropColumn("dbo.Forms", "Hour7GC");
            DropColumn("dbo.Forms", "Hour8GC");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Forms", "Hour8GC", c => c.Int(nullable: false));
            AddColumn("dbo.Forms", "Hour7GC", c => c.Int(nullable: false));
            AddColumn("dbo.Forms", "Hour6GC", c => c.Int(nullable: false));
            AddColumn("dbo.Forms", "Hour5GC", c => c.Int(nullable: false));
            AddColumn("dbo.Forms", "Hour4GC", c => c.Int(nullable: false));
            AddColumn("dbo.Forms", "Hour8Sales", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "Hour7Sales", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "Hour6Sales", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "Hour5Sales", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Forms", "Hour4Sales", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Forms", "ActualGcEight");
            DropColumn("dbo.Forms", "ActualGcSeven");
            DropColumn("dbo.Forms", "ActualGcSix");
            DropColumn("dbo.Forms", "ActualGcFive");
            DropColumn("dbo.Forms", "ActualGcFour");
            DropColumn("dbo.Forms", "ActualSalesEight");
            DropColumn("dbo.Forms", "ActualSalesSeven");
            DropColumn("dbo.Forms", "ActualSalesSix");
            DropColumn("dbo.Forms", "ActualSalesFive");
            DropColumn("dbo.Forms", "ActualSalesFour");
            DropColumn("dbo.Forms", "Scenario2Gc");
            DropColumn("dbo.Forms", "Scenario1Gc");
        }
    }
}

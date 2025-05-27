namespace ECommerceProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsNewSeason : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "IsNewSeason", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "IsNewSeason");
        }
    }
}

namespace ECommerceProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BannerLink : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Banners", "Link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Banners", "Link");
        }
    }
}

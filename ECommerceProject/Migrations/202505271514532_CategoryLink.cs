namespace ECommerceProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryLink : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Link");
        }
    }
}

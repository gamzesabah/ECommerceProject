﻿namespace ECommerceProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categorygüncellendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "ImageUrl");
        }
    }
}

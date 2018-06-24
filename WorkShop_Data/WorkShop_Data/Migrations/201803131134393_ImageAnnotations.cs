namespace WorkShop_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageAnnotations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "FileExtension", c => c.String(nullable: false, maxLength: 4));
            AddColumn("dbo.Images", "ImageUrl", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Images", "ImageUrl");
            DropColumn("dbo.Images", "FileExtension");
        }
    }
}

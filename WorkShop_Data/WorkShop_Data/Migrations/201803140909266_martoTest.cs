namespace WorkShop_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class martoTest : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Messages", "Author_ID", "dbo.UserProfiles");
            DropForeignKey("dbo.Images", "UserProfileID", "dbo.UserProfiles");
            AddForeignKey("dbo.Messages", "Author_ID", "dbo.UserProfiles", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Images", "UserProfileID", "dbo.UserProfiles", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "UserProfileID", "dbo.UserProfiles");
            DropForeignKey("dbo.Messages", "Author_ID", "dbo.UserProfiles");
            AddForeignKey("dbo.Images", "UserProfileID", "dbo.UserProfiles", "ID");
            AddForeignKey("dbo.Messages", "Author_ID", "dbo.UserProfiles", "ID");
        }
    }
}

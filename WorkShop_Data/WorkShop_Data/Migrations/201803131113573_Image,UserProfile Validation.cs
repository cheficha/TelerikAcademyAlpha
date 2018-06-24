namespace WorkShop_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageUserProfileValidation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserProfileID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfileID, cascadeDelete: true)
                .Index(t => t.UserProfileID);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        RegisteredOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Username, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "UserProfileID", "dbo.UserProfiles");
            DropIndex("dbo.UserProfiles", new[] { "Username" });
            DropIndex("dbo.Images", new[] { "UserProfileID" });
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Images");
        }
    }
}

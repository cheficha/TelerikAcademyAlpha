namespace WorkShop_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Postss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        PostedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.UserProfiles", "Post_ID", c => c.Int());
            CreateIndex("dbo.UserProfiles", "Post_ID");
            AddForeignKey("dbo.UserProfiles", "Post_ID", "dbo.Posts", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProfiles", "Post_ID", "dbo.Posts");
            DropIndex("dbo.UserProfiles", new[] { "Post_ID" });
            DropColumn("dbo.UserProfiles", "Post_ID");
            DropTable("dbo.Posts");
        }
    }
}

namespace WorkShop_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Friendship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friendships",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ApprovedStatus = c.Boolean(nullable: false),
                        FriendsSince = c.DateTime(),
                        Reciver_ID = c.Int(),
                        Sender_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserProfiles", t => t.Reciver_ID)
                .ForeignKey("dbo.UserProfiles", t => t.Sender_ID)
                .Index(t => t.Reciver_ID)
                .Index(t => t.Sender_ID);
            
            AddColumn("dbo.Messages", "Friendship_ID", c => c.Int());
            CreateIndex("dbo.Messages", "Friendship_ID");
            AddForeignKey("dbo.Messages", "Friendship_ID", "dbo.Friendships", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Friendships", "Sender_ID", "dbo.UserProfiles");
            DropForeignKey("dbo.Friendships", "Reciver_ID", "dbo.UserProfiles");
            DropForeignKey("dbo.Messages", "Friendship_ID", "dbo.Friendships");
            DropIndex("dbo.Messages", new[] { "Friendship_ID" });
            DropIndex("dbo.Friendships", new[] { "Sender_ID" });
            DropIndex("dbo.Friendships", new[] { "Reciver_ID" });
            DropColumn("dbo.Messages", "Friendship_ID");
            DropTable("dbo.Friendships");
        }
    }
}

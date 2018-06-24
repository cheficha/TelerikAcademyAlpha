namespace WorkShop_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FriendshipRequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Messages", "Author_ID", "dbo.UserProfiles");
            DropForeignKey("dbo.Images", "UserProfileID", "dbo.UserProfiles");
            DropIndex("dbo.Friendships", new[] { "Reciver_ID" });
            DropIndex("dbo.Friendships", new[] { "Sender_ID" });
            RenameColumn(table: "dbo.Friendships", name: "Sender_ID", newName: "SenderId");
            RenameColumn(table: "dbo.Friendships", name: "Reciver_ID", newName: "ReceiverId");
            AlterColumn("dbo.Friendships", "ReceiverId", c => c.Int(nullable: false));
            AlterColumn("dbo.Friendships", "SenderId", c => c.Int(nullable: false));
            CreateIndex("dbo.Friendships", "SenderId");
            CreateIndex("dbo.Friendships", "ReceiverId");
            AddForeignKey("dbo.Messages", "Author_ID", "dbo.UserProfiles", "ID");
            AddForeignKey("dbo.Images", "UserProfileID", "dbo.UserProfiles", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "UserProfileID", "dbo.UserProfiles");
            DropForeignKey("dbo.Messages", "Author_ID", "dbo.UserProfiles");
            DropIndex("dbo.Friendships", new[] { "ReceiverId" });
            DropIndex("dbo.Friendships", new[] { "SenderId" });
            AlterColumn("dbo.Friendships", "SenderId", c => c.Int());
            AlterColumn("dbo.Friendships", "ReceiverId", c => c.Int());
            RenameColumn(table: "dbo.Friendships", name: "ReceiverId", newName: "Reciver_ID");
            RenameColumn(table: "dbo.Friendships", name: "SenderId", newName: "Sender_ID");
            CreateIndex("dbo.Friendships", "Sender_ID");
            CreateIndex("dbo.Friendships", "Reciver_ID");
            AddForeignKey("dbo.Images", "UserProfileID", "dbo.UserProfiles", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Messages", "Author_ID", "dbo.UserProfiles", "ID", cascadeDelete: true);
        }
    }
}

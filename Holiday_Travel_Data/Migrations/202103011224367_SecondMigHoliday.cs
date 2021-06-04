namespace Holiday_Travel_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigHoliday : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comment", "BlogID", "dbo.Blog");
            DropPrimaryKey("dbo.About");
            DropPrimaryKey("dbo.Address");
            DropPrimaryKey("dbo.Blog");
            DropPrimaryKey("dbo.Comment");
            DropPrimaryKey("dbo.Contact");
            DropPrimaryKey("dbo.HomePage");
            AddColumn("dbo.Address", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.About", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Blog", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Comment", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Contact", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.HomePage", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.About", "ID");
            AddPrimaryKey("dbo.Address", "ID");
            AddPrimaryKey("dbo.Blog", "ID");
            AddPrimaryKey("dbo.Comment", "ID");
            AddPrimaryKey("dbo.Contact", "ID");
            AddPrimaryKey("dbo.HomePage", "ID");
            AddForeignKey("dbo.Comment", "BlogID", "dbo.Blog", "ID");
            DropColumn("dbo.About", "AboutId");
            DropColumn("dbo.About", "IsActivated");
            DropColumn("dbo.About", "CreatedTime");
            DropColumn("dbo.About", "OnModifiedTime");
            DropColumn("dbo.Address", "AdressId");
            DropColumn("dbo.Blog", "BlogId");
            DropColumn("dbo.Blog", "IsActivated");
            DropColumn("dbo.Blog", "CreatedTime");
            DropColumn("dbo.Blog", "OnModifiedTime");
            DropColumn("dbo.Comment", "CommentId");
            DropColumn("dbo.Comment", "IsActivated");
            DropColumn("dbo.Comment", "CreatedTime");
            DropColumn("dbo.Comment", "OnModifiedTime");
            DropColumn("dbo.Contact", "ContactId");
            DropColumn("dbo.Contact", "IsActivated");
            DropColumn("dbo.Contact", "CreatedTime");
            DropColumn("dbo.Contact", "OnModifiedTime");
            DropColumn("dbo.HomePage", "HomePageId");
            DropColumn("dbo.HomePage", "IsActivated");
            DropColumn("dbo.HomePage", "CreatedTime");
            DropColumn("dbo.HomePage", "OnModifiedTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HomePage", "OnModifiedTime", c => c.DateTime());
            AddColumn("dbo.HomePage", "CreatedTime", c => c.DateTime());
            AddColumn("dbo.HomePage", "IsActivated", c => c.Boolean(nullable: false));
            AddColumn("dbo.HomePage", "HomePageId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Contact", "OnModifiedTime", c => c.DateTime());
            AddColumn("dbo.Contact", "CreatedTime", c => c.DateTime());
            AddColumn("dbo.Contact", "IsActivated", c => c.Boolean(nullable: false));
            AddColumn("dbo.Contact", "ContactId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Comment", "OnModifiedTime", c => c.DateTime());
            AddColumn("dbo.Comment", "CreatedTime", c => c.DateTime());
            AddColumn("dbo.Comment", "IsActivated", c => c.Boolean(nullable: false));
            AddColumn("dbo.Comment", "CommentId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Blog", "OnModifiedTime", c => c.DateTime());
            AddColumn("dbo.Blog", "CreatedTime", c => c.DateTime());
            AddColumn("dbo.Blog", "IsActivated", c => c.Boolean(nullable: false));
            AddColumn("dbo.Blog", "BlogId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Address", "AdressId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.About", "OnModifiedTime", c => c.DateTime());
            AddColumn("dbo.About", "CreatedTime", c => c.DateTime());
            AddColumn("dbo.About", "IsActivated", c => c.Boolean(nullable: false));
            AddColumn("dbo.About", "AboutId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Comment", "BlogID", "dbo.Blog");
            DropPrimaryKey("dbo.HomePage");
            DropPrimaryKey("dbo.Contact");
            DropPrimaryKey("dbo.Comment");
            DropPrimaryKey("dbo.Blog");
            DropPrimaryKey("dbo.Address");
            DropPrimaryKey("dbo.About");
            AlterColumn("dbo.HomePage", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Contact", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Comment", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Blog", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.About", "ID", c => c.Int(nullable: false));
            DropColumn("dbo.Address", "ID");
            AddPrimaryKey("dbo.HomePage", "HomePageId");
            AddPrimaryKey("dbo.Contact", "ContactId");
            AddPrimaryKey("dbo.Comment", "CommentId");
            AddPrimaryKey("dbo.Blog", "BlogId");
            AddPrimaryKey("dbo.Address", "AdressId");
            AddPrimaryKey("dbo.About", "AboutId");
            AddForeignKey("dbo.Comment", "BlogID", "dbo.Blog", "BlogId");
        }
    }
}

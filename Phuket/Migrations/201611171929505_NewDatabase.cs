namespace Phuket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContentBlockCategory",
                c => new
                    {
                        ContentBlockCategoryID = c.Int(nullable: false, identity: true),
                        CBCategory = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.ContentBlockCategoryID);
            
            CreateTable(
                "dbo.ContentBlock",
                c => new
                    {
                        ContentBlockID = c.Int(nullable: false, identity: true),
                        CBHeader = c.String(nullable: false, maxLength: 100),
                        CBText = c.String(nullable: false),
                        CBEventDate = c.DateTime(nullable: false),
                        CBLastModified = c.DateTime(nullable: false),
                        CBActive = c.Boolean(nullable: false),
                        CBHighlighted = c.Boolean(nullable: false),
                        ContentBlockCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContentBlockID)
                .ForeignKey("dbo.ContentBlockCategory", t => t.ContentBlockCategoryID, cascadeDelete: true)
                .Index(t => t.ContentBlockCategoryID);
            
            CreateTable(
                "dbo.ContentBlockMedia",
                c => new
                    {
                        ContentBlockMediaID = c.Int(nullable: false, identity: true),
                        ContentBlockID = c.Int(nullable: false),
                        MediaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContentBlockMediaID)
                .ForeignKey("dbo.ContentBlock", t => t.ContentBlockID, cascadeDelete: true)
                .ForeignKey("dbo.Media", t => t.MediaID, cascadeDelete: true)
                .Index(t => t.ContentBlockID)
                .Index(t => t.MediaID);
            
            CreateTable(
                "dbo.Media",
                c => new
                    {
                        MediaID = c.Int(nullable: false, identity: true),
                        MediaCaption = c.String(nullable: false, maxLength: 50),
                        MediaSummary = c.String(nullable: false),
                        MediaEventDate = c.DateTime(nullable: false),
                        MediaLastModified = c.DateTime(nullable: false),
                        MediaHighlighted = c.Boolean(nullable: false),
                        MediaActive = c.Boolean(nullable: false),
                        MediaCategoryID = c.Int(nullable: false),
                        MediaFolder = c.String(nullable: false, maxLength: 25),
                        MediaPhysicalName = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.MediaID)
                .ForeignKey("dbo.MediaCategory", t => t.MediaCategoryID, cascadeDelete: true)
                .Index(t => t.MediaCategoryID);
            
            CreateTable(
                "dbo.MediaCategory",
                c => new
                    {
                        MediaCategoryID = c.Int(nullable: false, identity: true),
                        MediaCategoryDescription = c.String(nullable: false, maxLength: 100),
                        MediaCategoryExtension = c.String(nullable: false, maxLength: 4),
                        MediaCategoryMaxHeight = c.Int(nullable: false),
                        MediaCategoryMaxWidth = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MediaCategoryID);
            
            CreateTable(
                "dbo.MediaTag",
                c => new
                    {
                        MediaTagID = c.Int(nullable: false, identity: true),
                        TagID = c.Int(nullable: false),
                        MediaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MediaTagID)
                .ForeignKey("dbo.Media", t => t.MediaID, cascadeDelete: true)
                .ForeignKey("dbo.Tag", t => t.TagID, cascadeDelete: true)
                .Index(t => t.TagID)
                .Index(t => t.MediaID);
            
            CreateTable(
                "dbo.Tag",
                c => new
                    {
                        TagID = c.Int(nullable: false, identity: true),
                        TagKeyword = c.String(nullable: false, maxLength: 50),
                        TagType = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.TagID);
            
            CreateTable(
                "dbo.ContentBlockTag",
                c => new
                    {
                        ContentBlockTagID = c.Int(nullable: false, identity: true),
                        ContentBlockID = c.Int(nullable: false),
                        TagID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContentBlockTagID)
                .ForeignKey("dbo.ContentBlock", t => t.ContentBlockID, cascadeDelete: true)
                .ForeignKey("dbo.Tag", t => t.TagID, cascadeDelete: true)
                .Index(t => t.ContentBlockID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Page",
                c => new
                    {
                        PageID = c.Int(nullable: false, identity: true),
                        PageTitle = c.String(maxLength: 100),
                        PageText = c.String(),
                        PageLastModified = c.DateTime(nullable: false),
                        PageAuthor = c.String(maxLength: 100),
                        PageActive = c.Boolean(nullable: false),
                        PageSettingID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PageID)
                .ForeignKey("dbo.PageSetting", t => t.PageSettingID, cascadeDelete: true)
                .Index(t => t.PageSettingID);
            
            CreateTable(
                "dbo.PageSetting",
                c => new
                    {
                        PageSettingID = c.Int(nullable: false, identity: true),
                        PageLayoutSharedView = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.PageSettingID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Page", "PageSettingID", "dbo.PageSetting");
            DropForeignKey("dbo.MediaTag", "TagID", "dbo.Tag");
            DropForeignKey("dbo.ContentBlockTag", "TagID", "dbo.Tag");
            DropForeignKey("dbo.ContentBlockTag", "ContentBlockID", "dbo.ContentBlock");
            DropForeignKey("dbo.MediaTag", "MediaID", "dbo.Media");
            DropForeignKey("dbo.Media", "MediaCategoryID", "dbo.MediaCategory");
            DropForeignKey("dbo.ContentBlockMedia", "MediaID", "dbo.Media");
            DropForeignKey("dbo.ContentBlockMedia", "ContentBlockID", "dbo.ContentBlock");
            DropForeignKey("dbo.ContentBlock", "ContentBlockCategoryID", "dbo.ContentBlockCategory");
            DropIndex("dbo.Page", new[] { "PageSettingID" });
            DropIndex("dbo.ContentBlockTag", new[] { "TagID" });
            DropIndex("dbo.ContentBlockTag", new[] { "ContentBlockID" });
            DropIndex("dbo.MediaTag", new[] { "MediaID" });
            DropIndex("dbo.MediaTag", new[] { "TagID" });
            DropIndex("dbo.Media", new[] { "MediaCategoryID" });
            DropIndex("dbo.ContentBlockMedia", new[] { "MediaID" });
            DropIndex("dbo.ContentBlockMedia", new[] { "ContentBlockID" });
            DropIndex("dbo.ContentBlock", new[] { "ContentBlockCategoryID" });
            DropTable("dbo.PageSetting");
            DropTable("dbo.Page");
            DropTable("dbo.ContentBlockTag");
            DropTable("dbo.Tag");
            DropTable("dbo.MediaTag");
            DropTable("dbo.MediaCategory");
            DropTable("dbo.Media");
            DropTable("dbo.ContentBlockMedia");
            DropTable("dbo.ContentBlock");
            DropTable("dbo.ContentBlockCategory");
        }
    }
}

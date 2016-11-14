namespace Phuket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSeed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContentBlocks",
                c => new
                    {
                        ContentBlockID = c.Int(nullable: false, identity: true),
                        ContentBlockHeaderTitle = c.String(),
                        ContentBlockSummary = c.String(),
                        ContentBlockParentContentBlock = c.Boolean(nullable: false),
                        ParentContentBlockID = c.Int(),
                        ContentBlock_ContentBlockID = c.Int(),
                        Page_PageID = c.Int(),
                    })
                .PrimaryKey(t => t.ContentBlockID)
                .ForeignKey("dbo.ContentBlocks", t => t.ContentBlock_ContentBlockID)
                .ForeignKey("dbo.Pages", t => t.Page_PageID)
                .Index(t => t.ContentBlock_ContentBlockID)
                .Index(t => t.Page_PageID);
            
            CreateTable(
                "dbo.MediaItems",
                c => new
                    {
                        MediaItemID = c.Int(nullable: false, identity: true),
                        MediaItemURL = c.String(),
                        MediaItemActive = c.Boolean(nullable: false),
                        MediaItemHeight = c.Int(nullable: false),
                        MediaItemWidth = c.Int(nullable: false),
                        MediaItemShortDescription = c.String(),
                        MediaItemLongDescription = c.String(),
                        MediaCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MediaItemID)
                .ForeignKey("dbo.MediaCategories", t => t.MediaCategoryID, cascadeDelete: true)
                .Index(t => t.MediaCategoryID);
            
            CreateTable(
                "dbo.MediaCategories",
                c => new
                    {
                        MediaCategoryID = c.Int(nullable: false, identity: true),
                        MediaCategoryType = c.String(),
                    })
                .PrimaryKey(t => t.MediaCategoryID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagID = c.Int(nullable: false, identity: true),
                        TagKeyword = c.String(),
                    })
                .PrimaryKey(t => t.TagID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        PageID = c.Int(nullable: false, identity: true),
                        PageTitle = c.String(),
                        PageFileName = c.String(),
                        PageLastModified = c.DateTime(nullable: false),
                        PageAuthor = c.String(),
                        PageActive = c.Boolean(nullable: false),
                        PageParentPageID = c.Int(),
                        SettingID = c.Int(nullable: false),
                        Page_PageID = c.Int(),
                    })
                .PrimaryKey(t => t.PageID)
                .ForeignKey("dbo.Pages", t => t.Page_PageID)
                .ForeignKey("dbo.Settings", t => t.SettingID, cascadeDelete: true)
                .Index(t => t.SettingID)
                .Index(t => t.Page_PageID);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        SettingID = c.Int(nullable: false, identity: true),
                        SettingSharedLayout = c.String(),
                        SettingPageType = c.String(),
                    })
                .PrimaryKey(t => t.SettingID);
            
            CreateTable(
                "dbo.MediaItemContentBlocks",
                c => new
                    {
                        MediaItem_MediaItemID = c.Int(nullable: false),
                        ContentBlock_ContentBlockID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MediaItem_MediaItemID, t.ContentBlock_ContentBlockID })
                .ForeignKey("dbo.MediaItems", t => t.MediaItem_MediaItemID, cascadeDelete: true)
                .ForeignKey("dbo.ContentBlocks", t => t.ContentBlock_ContentBlockID, cascadeDelete: true)
                .Index(t => t.MediaItem_MediaItemID)
                .Index(t => t.ContentBlock_ContentBlockID);
            
            CreateTable(
                "dbo.TagMediaItems",
                c => new
                    {
                        Tag_TagID = c.Int(nullable: false),
                        MediaItem_MediaItemID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_TagID, t.MediaItem_MediaItemID })
                .ForeignKey("dbo.Tags", t => t.Tag_TagID, cascadeDelete: true)
                .ForeignKey("dbo.MediaItems", t => t.MediaItem_MediaItemID, cascadeDelete: true)
                .Index(t => t.Tag_TagID)
                .Index(t => t.MediaItem_MediaItemID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pages", "SettingID", "dbo.Settings");
            DropForeignKey("dbo.Pages", "Page_PageID", "dbo.Pages");
            DropForeignKey("dbo.ContentBlocks", "Page_PageID", "dbo.Pages");
            DropForeignKey("dbo.TagMediaItems", "MediaItem_MediaItemID", "dbo.MediaItems");
            DropForeignKey("dbo.TagMediaItems", "Tag_TagID", "dbo.Tags");
            DropForeignKey("dbo.MediaItems", "MediaCategoryID", "dbo.MediaCategories");
            DropForeignKey("dbo.MediaItemContentBlocks", "ContentBlock_ContentBlockID", "dbo.ContentBlocks");
            DropForeignKey("dbo.MediaItemContentBlocks", "MediaItem_MediaItemID", "dbo.MediaItems");
            DropForeignKey("dbo.ContentBlocks", "ContentBlock_ContentBlockID", "dbo.ContentBlocks");
            DropIndex("dbo.TagMediaItems", new[] { "MediaItem_MediaItemID" });
            DropIndex("dbo.TagMediaItems", new[] { "Tag_TagID" });
            DropIndex("dbo.MediaItemContentBlocks", new[] { "ContentBlock_ContentBlockID" });
            DropIndex("dbo.MediaItemContentBlocks", new[] { "MediaItem_MediaItemID" });
            DropIndex("dbo.Pages", new[] { "Page_PageID" });
            DropIndex("dbo.Pages", new[] { "SettingID" });
            DropIndex("dbo.MediaItems", new[] { "MediaCategoryID" });
            DropIndex("dbo.ContentBlocks", new[] { "Page_PageID" });
            DropIndex("dbo.ContentBlocks", new[] { "ContentBlock_ContentBlockID" });
            DropTable("dbo.TagMediaItems");
            DropTable("dbo.MediaItemContentBlocks");
            DropTable("dbo.Settings");
            DropTable("dbo.Pages");
            DropTable("dbo.Tags");
            DropTable("dbo.MediaCategories");
            DropTable("dbo.MediaItems");
            DropTable("dbo.ContentBlocks");
        }
    }
}

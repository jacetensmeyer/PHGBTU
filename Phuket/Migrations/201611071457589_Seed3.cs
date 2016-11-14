namespace Phuket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ContentBlocks", newName: "ContentBlock");
            RenameTable(name: "dbo.MediaItems", newName: "MediaItem");
            RenameTable(name: "dbo.MediaCategories", newName: "MediaCategory");
            RenameTable(name: "dbo.Tags", newName: "Tag");
            RenameTable(name: "dbo.Pages", newName: "Page");
            RenameTable(name: "dbo.Settings", newName: "Setting");
            RenameTable(name: "dbo.MediaItemContentBlocks", newName: "MediaItemContentBlock");
            RenameTable(name: "dbo.TagMediaItems", newName: "MediaItemTag");
            RenameColumn(table: "dbo.MediaItemContentBlock", name: "MediaItem_MediaItemID", newName: "MediaItemID");
            RenameColumn(table: "dbo.MediaItemContentBlock", name: "ContentBlock_ContentBlockID", newName: "ContentBlockID");
            RenameColumn(table: "dbo.MediaItemTag", name: "Tag_TagID", newName: "TagID");
            RenameColumn(table: "dbo.MediaItemTag", name: "MediaItem_MediaItemID", newName: "MediaItemID");
            RenameIndex(table: "dbo.MediaItemContentBlock", name: "IX_MediaItem_MediaItemID", newName: "IX_MediaItemID");
            RenameIndex(table: "dbo.MediaItemContentBlock", name: "IX_ContentBlock_ContentBlockID", newName: "IX_ContentBlockID");
            RenameIndex(table: "dbo.MediaItemTag", name: "IX_MediaItem_MediaItemID", newName: "IX_MediaItemID");
            RenameIndex(table: "dbo.MediaItemTag", name: "IX_Tag_TagID", newName: "IX_TagID");
            DropPrimaryKey("dbo.MediaItemTag");
            AddPrimaryKey("dbo.MediaItemTag", new[] { "MediaItemID", "TagID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.MediaItemTag");
            AddPrimaryKey("dbo.MediaItemTag", new[] { "Tag_TagID", "MediaItem_MediaItemID" });
            RenameIndex(table: "dbo.MediaItemTag", name: "IX_TagID", newName: "IX_Tag_TagID");
            RenameIndex(table: "dbo.MediaItemTag", name: "IX_MediaItemID", newName: "IX_MediaItem_MediaItemID");
            RenameIndex(table: "dbo.MediaItemContentBlock", name: "IX_ContentBlockID", newName: "IX_ContentBlock_ContentBlockID");
            RenameIndex(table: "dbo.MediaItemContentBlock", name: "IX_MediaItemID", newName: "IX_MediaItem_MediaItemID");
            RenameColumn(table: "dbo.MediaItemTag", name: "MediaItemID", newName: "MediaItem_MediaItemID");
            RenameColumn(table: "dbo.MediaItemTag", name: "TagID", newName: "Tag_TagID");
            RenameColumn(table: "dbo.MediaItemContentBlock", name: "ContentBlockID", newName: "ContentBlock_ContentBlockID");
            RenameColumn(table: "dbo.MediaItemContentBlock", name: "MediaItemID", newName: "MediaItem_MediaItemID");
            RenameTable(name: "dbo.MediaItemTag", newName: "TagMediaItems");
            RenameTable(name: "dbo.MediaItemContentBlock", newName: "MediaItemContentBlocks");
            RenameTable(name: "dbo.Setting", newName: "Settings");
            RenameTable(name: "dbo.Page", newName: "Pages");
            RenameTable(name: "dbo.Tag", newName: "Tags");
            RenameTable(name: "dbo.MediaCategory", newName: "MediaCategories");
            RenameTable(name: "dbo.MediaItem", newName: "MediaItems");
            RenameTable(name: "dbo.ContentBlock", newName: "ContentBlocks");
        }
    }
}

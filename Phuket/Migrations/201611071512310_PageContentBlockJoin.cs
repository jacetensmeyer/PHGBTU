namespace Phuket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PageContentBlockJoin : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ContentBlock", "Page_PageID", "dbo.Page");
            DropIndex("dbo.ContentBlock", new[] { "Page_PageID" });
            CreateTable(
                "dbo.PageContentBlock",
                c => new
                    {
                        PageID = c.Int(nullable: false),
                        ContentBlockID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PageID, t.ContentBlockID })
                .ForeignKey("dbo.Page", t => t.PageID, cascadeDelete: true)
                .ForeignKey("dbo.ContentBlock", t => t.ContentBlockID, cascadeDelete: true)
                .Index(t => t.PageID)
                .Index(t => t.ContentBlockID);
            
            DropColumn("dbo.ContentBlock", "Page_PageID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ContentBlock", "Page_PageID", c => c.Int());
            DropForeignKey("dbo.PageContentBlock", "ContentBlockID", "dbo.ContentBlock");
            DropForeignKey("dbo.PageContentBlock", "PageID", "dbo.Page");
            DropIndex("dbo.PageContentBlock", new[] { "ContentBlockID" });
            DropIndex("dbo.PageContentBlock", new[] { "PageID" });
            DropTable("dbo.PageContentBlock");
            CreateIndex("dbo.ContentBlock", "Page_PageID");
            AddForeignKey("dbo.ContentBlock", "Page_PageID", "dbo.Page", "PageID");
        }
    }
}

namespace Phuket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newSchema : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ContentBlock", "ContentBlockCategory_ContentBlockCategoryID", "dbo.ContentBlockCategory");
            DropIndex("dbo.ContentBlock", new[] { "ContentBlockCategory_ContentBlockCategoryID" });
            RenameColumn(table: "dbo.ContentBlock", name: "ContentBlockCategory_ContentBlockCategoryID", newName: "ContentBlockCategoryID");
            AlterColumn("dbo.ContentBlock", "ContentBlockCategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.ContentBlock", "ContentBlockCategoryID");
            AddForeignKey("dbo.ContentBlock", "ContentBlockCategoryID", "dbo.ContentBlockCategory", "ContentBlockCategoryID", cascadeDelete: true);
            DropColumn("dbo.ContentBlock", "CBCategoryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ContentBlock", "CBCategoryID", c => c.Int(nullable: false));
            DropForeignKey("dbo.ContentBlock", "ContentBlockCategoryID", "dbo.ContentBlockCategory");
            DropIndex("dbo.ContentBlock", new[] { "ContentBlockCategoryID" });
            AlterColumn("dbo.ContentBlock", "ContentBlockCategoryID", c => c.Int());
            RenameColumn(table: "dbo.ContentBlock", name: "ContentBlockCategoryID", newName: "ContentBlockCategory_ContentBlockCategoryID");
            CreateIndex("dbo.ContentBlock", "ContentBlockCategory_ContentBlockCategoryID");
            AddForeignKey("dbo.ContentBlock", "ContentBlockCategory_ContentBlockCategoryID", "dbo.ContentBlockCategory", "ContentBlockCategoryID");
        }
    }
}

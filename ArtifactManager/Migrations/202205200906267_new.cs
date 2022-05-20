namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Elements", "Category2_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Elements", "Category1_CategoryId", "dbo.Categories");
            DropIndex("dbo.Elements", new[] { "Category1_CategoryId" });
            DropIndex("dbo.Elements", new[] { "Category2_CategoryId" });
            RenameColumn(table: "dbo.Elements", name: "Category1_CategoryId", newName: "CategoryId");
            CreateTable(
                "dbo.ElementAttributes",
                c => new
                    {
                        ElementAttributeId = c.Int(nullable: false, identity: true),
                        ElementAttributeName = c.String(),
                        ElementAttributeType = c.String(),
                        ElementId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ElementAttributeId)
                .ForeignKey("dbo.Elements", t => t.ElementId, cascadeDelete: true)
                .Index(t => t.ElementId);
            
            AlterColumn("dbo.Elements", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Elements", "CategoryId");
            AddForeignKey("dbo.Elements", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
            DropColumn("dbo.Elements", "Category2_CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Elements", "Category2_CategoryId", c => c.Int());
            DropForeignKey("dbo.Elements", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.ElementAttributes", "ElementId", "dbo.Elements");
            DropIndex("dbo.ElementAttributes", new[] { "ElementId" });
            DropIndex("dbo.Elements", new[] { "CategoryId" });
            AlterColumn("dbo.Elements", "CategoryId", c => c.Int());
            DropTable("dbo.ElementAttributes");
            RenameColumn(table: "dbo.Elements", name: "CategoryId", newName: "Category1_CategoryId");
            CreateIndex("dbo.Elements", "Category2_CategoryId");
            CreateIndex("dbo.Elements", "Category1_CategoryId");
            AddForeignKey("dbo.Elements", "Category1_CategoryId", "dbo.Categories", "CategoryId");
            AddForeignKey("dbo.Elements", "Category2_CategoryId", "dbo.Categories", "CategoryId");
        }
    }
}

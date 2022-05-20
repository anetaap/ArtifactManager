namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class artifacts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artifacts",
                c => new
                    {
                        ArtifactId = c.Int(nullable: false, identity: true),
                        ArtifactName = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        ElementId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArtifactId);
            
            CreateTable(
                "dbo.ArtifactCategories",
                c => new
                    {
                        ArtifactCategoryId = c.Int(nullable: false, identity: true),
                        CategoryAttributeId = c.Int(nullable: false),
                        CategoryAttributeValue = c.String(),
                        ArtifactId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArtifactCategoryId)
                .ForeignKey("dbo.Artifacts", t => t.ArtifactId, cascadeDelete: true)
                .Index(t => t.ArtifactId);
            
            CreateTable(
                "dbo.ArtifactElements",
                c => new
                    {
                        ArtifactElementId = c.Int(nullable: false, identity: true),
                        ElementAttributeId = c.Int(nullable: false),
                        ElementAttributeValue = c.String(),
                        ArtifactId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArtifactElementId)
                .ForeignKey("dbo.Artifacts", t => t.ArtifactId, cascadeDelete: true)
                .Index(t => t.ArtifactId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArtifactElements", "ArtifactId", "dbo.Artifacts");
            DropForeignKey("dbo.ArtifactCategories", "ArtifactId", "dbo.Artifacts");
            DropIndex("dbo.ArtifactElements", new[] { "ArtifactId" });
            DropIndex("dbo.ArtifactCategories", new[] { "ArtifactId" });
            DropTable("dbo.ArtifactElements");
            DropTable("dbo.ArtifactCategories");
            DropTable("dbo.Artifacts");
        }
    }
}

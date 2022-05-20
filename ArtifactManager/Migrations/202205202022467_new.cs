namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Artifacts", "UserCategory_UserCategoryId", "dbo.UserCategories");
            DropIndex("dbo.Artifacts", new[] { "UserCategory_UserCategoryId" });
            RenameColumn(table: "dbo.Artifacts", name: "UserCategory_UserCategoryId", newName: "UserCategoryId");
            AlterColumn("dbo.Artifacts", "UserCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Artifacts", "UserCategoryId");
            AddForeignKey("dbo.Artifacts", "UserCategoryId", "dbo.UserCategories", "UserCategoryId", cascadeDelete: true);
            DropColumn("dbo.Artifacts", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Artifacts", "CategoryId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Artifacts", "UserCategoryId", "dbo.UserCategories");
            DropIndex("dbo.Artifacts", new[] { "UserCategoryId" });
            AlterColumn("dbo.Artifacts", "UserCategoryId", c => c.Int());
            RenameColumn(table: "dbo.Artifacts", name: "UserCategoryId", newName: "UserCategory_UserCategoryId");
            CreateIndex("dbo.Artifacts", "UserCategory_UserCategoryId");
            AddForeignKey("dbo.Artifacts", "UserCategory_UserCategoryId", "dbo.UserCategories", "UserCategoryId");
        }
    }
}

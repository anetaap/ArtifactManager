namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KURWA : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.PermissionRoles", newName: "RolePermissions");
            DropForeignKey("dbo.Categories", "UserId", "dbo.Users");
            DropIndex("dbo.Categories", new[] { "UserId" });
            DropPrimaryKey("dbo.RolePermissions");
            AddColumn("dbo.Permissions", "CategoryId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.RolePermissions", new[] { "Role_RoleId", "Permission_PermissionId" });
            CreateIndex("dbo.Permissions", "CategoryId");
            AddForeignKey("dbo.Permissions", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Permissions", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Permissions", new[] { "CategoryId" });
            DropPrimaryKey("dbo.RolePermissions");
            DropColumn("dbo.Permissions", "CategoryId");
            AddPrimaryKey("dbo.RolePermissions", new[] { "Permission_PermissionId", "Role_RoleId" });
            CreateIndex("dbo.Categories", "UserId");
            AddForeignKey("dbo.Categories", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
            RenameTable(name: "dbo.RolePermissions", newName: "PermissionRoles");
        }
    }
}

namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurwaXD : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.RolePermissions", newName: "PermissionRoles");
            DropPrimaryKey("dbo.PermissionRoles");
            AddColumn("dbo.Users", "RoleId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.PermissionRoles", new[] { "Permission_PermissionId", "Role_RoleId" });
            CreateIndex("dbo.Users", "RoleId");
            AddForeignKey("dbo.Users", "RoleId", "dbo.Roles", "RoleId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropPrimaryKey("dbo.PermissionRoles");
            DropColumn("dbo.Users", "RoleId");
            AddPrimaryKey("dbo.PermissionRoles", new[] { "Role_RoleId", "Permission_PermissionId" });
            RenameTable(name: "dbo.PermissionRoles", newName: "RolePermissions");
        }
    }
}

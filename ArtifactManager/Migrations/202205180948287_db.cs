namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Elements",
                c => new
                    {
                        ElementId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ElementId);
            
            CreateTable(
                "dbo.ElementAtributes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        ElementId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Elements", t => t.ElementId, cascadeDelete: true)
                .Index(t => t.ElementId);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        PermissionId = c.Int(nullable: false, identity: true),
                        PermissionName = c.String(),
                    })
                .PrimaryKey(t => t.PermissionId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.RolePermissions",
                c => new
                    {
                        Role_RoleId = c.Int(nullable: false),
                        Permission_PermissionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_RoleId, t.Permission_PermissionId })
                .ForeignKey("dbo.Roles", t => t.Role_RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Permissions", t => t.Permission_PermissionId, cascadeDelete: true)
                .Index(t => t.Role_RoleId)
                .Index(t => t.Permission_PermissionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolePermissions", "Permission_PermissionId", "dbo.Permissions");
            DropForeignKey("dbo.RolePermissions", "Role_RoleId", "dbo.Roles");
            DropForeignKey("dbo.ElementAtributes", "ElementId", "dbo.Elements");
            DropIndex("dbo.RolePermissions", new[] { "Permission_PermissionId" });
            DropIndex("dbo.RolePermissions", new[] { "Role_RoleId" });
            DropIndex("dbo.ElementAtributes", new[] { "ElementId" });
            DropTable("dbo.RolePermissions");
            DropTable("dbo.Roles");
            DropTable("dbo.Permissions");
            DropTable("dbo.ElementAtributes");
            DropTable("dbo.Elements");
        }
    }
}

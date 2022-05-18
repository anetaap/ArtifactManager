namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xdddd : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Elements", "CategoryId1");
            DropColumn("dbo.Elements", "CategoryId2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Elements", "CategoryId2", c => c.Int(nullable: false));
            AddColumn("dbo.Elements", "CategoryId1", c => c.Int(nullable: false));
        }
    }
}

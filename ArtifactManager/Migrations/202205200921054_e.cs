namespace ArtifactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class e : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Elements", "ElementName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Elements", "ElementName");
        }
    }
}

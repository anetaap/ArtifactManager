using System.Data.Entity;
using ArtifactManager.DataBase.Model;

namespace ArtifactManager.DataBase.Context
{
    public class MyDbContext: DbContext
    {
        public MyDbContext() : base("MyConnectionString")
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Element> Elements { set; get; }
        public DbSet<ElementAttribute> ElementAttributes { set; get; }
        public DbSet<Permission> Permissions { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<CategoryAttribute> CategoryAttributes { set; get; }
        public DbSet<Role> Roles { set; get; }
        public DbSet<Artifact> Artifacts { set; get; }
    }
}
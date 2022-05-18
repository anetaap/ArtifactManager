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
        // public DbSet<Admin> Admins { get; set; }
        public DbSet<Element> Elements { set; get; }
        public DbSet<Permission> Permissions { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Role> Roles { set; get; }
    }
}
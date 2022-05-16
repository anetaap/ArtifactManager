
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ArtifactManager.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ArtifactManager.DataBase.Context.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}
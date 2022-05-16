using System;
using System.Collections.Generic;

namespace ArtifactManager.DataBase.Model
{
    public class User
    {
        public int UserId { set; get; }
        public String Username { set; get; }
        public String Name { set; get; }
        public String Lastname { set; get; }
        public String Email { set; get; }
        public String Password { set; get; }
        public String Role { set; get; }
        
        public virtual List<Category> Categories { get; set; }
    }

    public class Admin
    {
        public String Username { set; get; }
        public String Password { set; get; }
    }
}
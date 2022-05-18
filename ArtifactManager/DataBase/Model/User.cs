using System.Collections.Generic;

namespace ArtifactManager.DataBase.Model
{
    public class User
    {
        public int UserId { set; get; }
        public string Username { set; get; }
        public string Name { set; get; }
        public string Lastname { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }

        public int RoleId { set; get; }
        public virtual Role Role { set; get; }
        
        // public virtual List<Category> Categories { get; set; }
    }
}
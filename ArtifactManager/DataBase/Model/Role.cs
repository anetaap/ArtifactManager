using System;
using System.Collections.Generic;

namespace ArtifactManager.DataBase.Model
{
    public class Role
    {
        public Role()
        {
            Permissions = new HashSet<Permission>();
        }

        public int RoleId { set; get; }
        public String RoleName { set; get; }
        
        public virtual ICollection<Permission> Permissions { set; get; }
    }
}
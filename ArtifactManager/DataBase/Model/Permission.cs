using System;
using System.Collections.Generic;

namespace ArtifactManager.DataBase.Model
{
    public class Permission
    {
        public int PermissionId { set; get; }
        public String PermissionName { set; get; }
        
        public virtual ICollection<Role> Roles { set; get; }
    }
}
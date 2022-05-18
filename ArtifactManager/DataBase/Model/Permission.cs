using System.Collections.Generic;

namespace ArtifactManager.DataBase.Model
{
    public class Permission
    {
        public int PermissionId { set; get; }
        public string PermissionName { set; get; }
        public bool Add { set; get; }
        public bool Update { set; get; }
        public bool Remove { set; get; }
        
        public int CategoryId { set; get; }
        public virtual Category Category { set; get; }

        public virtual ICollection<Role> Roles { set; get; }
    }
}
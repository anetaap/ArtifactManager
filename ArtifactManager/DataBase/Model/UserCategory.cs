using System.Collections.Generic;

namespace ArtifactManager.DataBase.Model
{
    public class UserCategory
    {
        public int UserCategoryId { set; get; }
        public int CategoryId { set; get; }
        public int UserId { set; get; }
        public string CategoryName { set; get; }
        
        public virtual List<Artifact> Artifacts { set; get; }
        public virtual List<UserCategoryAttribute> UserCategoryAttributes { set; get; }
    }
}
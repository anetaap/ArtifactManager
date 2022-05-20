using System.Collections.Generic;

namespace ArtifactManager.DataBase.Model
{
    public class UserCategoryAttribute
    {
        public int UserCategoryAttributeId { set; get; }
        public int CategoryAttributeId { set; get; }  
        public string CategoryAttributeValue { set; get; }
        
        public int UserCategoryId { set; get; }
        public virtual UserCategory UserCategory { set; get; }
    }
}
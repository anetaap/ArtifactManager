using System.Collections.Generic;

namespace ArtifactManager.DataBase.Model
{
    public class Category
    {
        public int CategoryId { set; get; }
        public string CategoryName { set; get; }
        
        public int UserId { set; get; }
        // public virtual User User { set; get; }
        
        public virtual List<CategoryAttribute> CategoryAttributes { set; get; }

    }

    public class CategoryAttribute
    {
        public int CategoryAttributeId { set; get; }
        public string CategoryAttributeName { set; get; }
        public string CategoryAttributeType { set; get; }
        
        public int CategoryId { set; get; }
        public virtual Category Category { set; get; }
    }
}
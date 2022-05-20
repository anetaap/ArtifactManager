using System.Collections.Generic;

namespace ArtifactManager.DataBase.Model
{
    public class Element
    {
        public int ElementId { set; get; }
        public string ElementName { set; get; }
        public int CategoryId { set; get; }
        public virtual Category Category { set; get; }
        public virtual List<ElementAttribute> ElementAttributes { get; set; }
        
        // id of Category that becomes element in other category
        // public virtual Category Category2 { set; get; }
    }

    public class ElementAttribute
    {
        public int ElementAttributeId { set; get; }
        public string ElementAttributeName { set; get; }
        public string ElementAttributeType { set; get; }
        
        public int ElementId { set; get; }
        public virtual Element Element { set; get; }
    }
}
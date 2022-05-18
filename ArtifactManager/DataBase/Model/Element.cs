using System;
using System.Collections.Generic;

namespace ArtifactManager.DataBase.Model
{
    public class Element
    {
        public int ElementId { set; get; }
        // id of Category that becomes element in other category
        public virtual Category Category1 { set; get; }
        public virtual Category Category2 { set; get; }
        
        // public virtual List<ElementAttribute> ElementAttributes { get; set; }
    }

    // public class ElementAttribute
    // {
    //     public int ElementAttributeId { set; get; }
    //     public String ElementAttributeName { set; get; }
    //     public String ElementAttributeType { set; get; }
    //     
    //     public int ElementId { set; get; }
    //     public virtual Element Element { set; get; }
    // }
}
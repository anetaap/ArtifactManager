using System;
using System.Collections.Generic;

namespace ArtifactManager.DataBase.Model
{
    public class Element
    {
        public int ElementId { set; get; }

        public virtual List<ElementAtribute> ElementAtributes { get; set; }
    }

    public class ElementAtribute
    {
        public int Id { set; get; }
        public String Name { set; get; }
        public String Type { set; get; }
        
        public int ElementId { set; get; }
        public virtual Element Element { set; get; }
    }
}
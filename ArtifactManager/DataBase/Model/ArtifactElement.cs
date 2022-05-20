
namespace ArtifactManager.DataBase.Model
{
    public class ArtifactElement
    {
        public int ArtifactElementId { set; get; }
        public int ElementAttributeId { set; get; } 
        public string ElementAttributeValue { set; get; }
        
        public int ArtifactId { set; get; }
        public virtual Artifact Artifact { set; get; }
    }
}
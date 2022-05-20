namespace ArtifactManager.DataBase.Model
{
    public class ArtifactCategory
    {
        public int ArtifactCategoryId { set; get; }
        public int CategoryAttributeId { set; get; }  
        public string CategoryAttributeValue { set; get; }
        
        public int ArtifactId { set; get; }
        public virtual Artifact Artifact { set; get; }
    }
}
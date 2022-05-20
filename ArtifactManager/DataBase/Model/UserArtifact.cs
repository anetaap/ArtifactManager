using System.Collections.Generic;

namespace ArtifactManager.DataBase.Model
{
    public class Artifact
    {
        public int ArtifactId { set; get; }
        public int ElementId { set; get; }
        public string ArtifactName { set; get; }
        public int UserCategoryId { set; get; }
        public virtual UserCategory UserCategory { set; get; }
        
        public virtual List<UserArtifactAttribute> UserArtifactAttributes { set; get; }
    }
}
using System.Collections.Generic;

namespace ArtifactManager.DataBase.Model
{
    public class Artifact
    {
        public int ArtifactId { set; get; }
        public int ArtifactName { set; get; }
        public int CategoryId { set; get; }
        public int ElementId { set; get; }

        public virtual List<ArtifactCategory> ArtifactCategories { set; get; }
        public virtual List<ArtifactElement> ArtifactElements { set; get; }
    }
}
namespace ArtifactManager.DataBase.Model
{
    public class Category
    {
        public int CategoryId { set; get; }
        public string CategoryName { set; get; }
        
        public int UserId { set; get; }
        public virtual User User { set; get; }
    }
}
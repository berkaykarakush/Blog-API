namespace Blog_API.Domain.Entities
{
    public class ArticleImageFile : File
    {
        // This property indicates whether a files is a showcase or not
        public bool Showcase { get; set; }
        // This collection holds the collection of articles associated with this file
        public ICollection<Article> Articles { get; set; }
    }
}

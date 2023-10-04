using Blog_API.Domain.Entities.Common;

namespace Blog_API.Domain.Entities
{
    public class Comment : BaseEntity
    {
        // The content of the comment
        public string Content { get; set; }
        
        //public string User { get; set; }

        // The unique identifier (Id) of the associated article 
        public double ArticleId { get; set; }

        // The associated article entity
        public Article Article { get; set; }
    }
}

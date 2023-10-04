using Blog_API.Domain.Entities.Common;

namespace Blog_API.Domain.Entities
{
    public class Tag : BaseEntity
    {
        // The name of the tag
        public string TagName { get; set; }

        // The unique identifier (Id) of the associated article
        public double ArticleId { get; set; }

        // The associated article entity
        public Article Article { get; set; }
    }
}

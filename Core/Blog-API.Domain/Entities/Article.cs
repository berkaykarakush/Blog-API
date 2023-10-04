using Blog_API.Domain.Entities.Common;

namespace Blog_API.Domain.Entities
{
    public class Article : BaseEntity
    {
        //The title of the article
        public string Title { get; set; }
        // The content or body of the article
        public string Content { get; set; }
        // A collection of tags associated with the article
        public ICollection<Tag> Tags { get; set; }
        //A collection of comments related to the article
        public ICollection<Comment> Comments { get; set; }
        // A collection of images associated with the article
        public ICollection<ArticleImageFile>  ArticleImageFiles { get; set; }

        // The author of the article
        //public string Author{ get; set; }
    }
}

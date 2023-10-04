using Blog_API.Application.Repositories;
using Blog_API.Domain.Entities;
using Blog_API.Persistence.Contexts;

// This namespace is introduced to resolve naming conflicts between the ArticleImageFile class and ArticleImageFile file.
namespace Blog_API.Persistence.Repositories
{
    /// <summary>
    /// This class representing a specified read repository for the ArticleImageFile entity, inheriting from the generic ReadRepository and implementing the IArticleImageFileReadRepository interface
    /// </summary>
    public class ArticleImageFileReadRepository : ReadRepository<ArticleImageFile>, IArticleImageFileReadRepository
    {
        /// <summary>
        /// Constructor that takes an instance of the ApplicationDbContext and calls the base contstructor
        /// </summary>
        public ArticleImageFileReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

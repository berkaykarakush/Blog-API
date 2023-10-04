using Blog_API.Application.Repositories;
using Blog_API.Domain.Entities;
using Blog_API.Persistence.Contexts;

// This namespace is introduced to resolve naming conflicts between the 'Article' class and 'Article' file.
namespace Blog_API.Persistence.Repositories
{
    /// <summary>
    /// This class represents a specific read repository for the Article entity, inheriting from the generic ReadRepository and implmenting the IArticleReadRepository interface
    /// </summary>
    public class ArticleReadRepository : ReadRepository<Article>, IArticleReadRepository
    {
        /// <summary>
        /// Constructor that takes an instance of the ApplicationDbContext and calls the base constructor
        /// </summary>
        public ArticleReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

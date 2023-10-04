using Blog_API.Application.Repositories;
using Blog_API.Domain.Entities;
using Blog_API.Persistence.Contexts;

// This namespace is introduced to resolve naming conflicts between the 'Article' class and 'Article' file.
namespace Blog_API.Persistence.Repositories
{
    /// <summary>
    /// This class represents a specific write repository for the Article entity, inhteriting from the generic WriteRepository and implementing the IArticleWriteRepository interface
    /// </summary>
    public class ArticleWriteRepository : WriteRepository<Article>, IArticleWriteRepository
    {
        /// <summary>
        /// Constructor that takes an instance of the ApplicationDbContext and calls the base constructor
        /// </summary>
        public ArticleWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

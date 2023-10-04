using Blog_API.Application.Repositories;
using Blog_API.Domain.Entities;
using Blog_API.Persistence.Contexts;

// This namespace is introduced to resolve naming conflicts between the ArticleImageFile class and ArticleImageFile file.
namespace Blog_API.Persistence.Repositories
{
    /// <summary>
    /// This class represents a specific write repository for the ArticleImageFile entity, inheriting from the generic WriteRepository and implementing the IArticleImageFileWriteRepository interface
    /// </summary>
    public class ArticleImageFileWriteRepository : WriteRepository<ArticleImageFile>, IArticleImageFileWriteRepository
    {
        /// <summary>
        /// Constructor takes an instance of the ApplicationDbContext and calls the base constructor
        /// </summary>
        public ArticleImageFileWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

using Blog_API.Domain.Entities;

// This namespace is introduced to resolve naming conflicts between the 'Article' class and 'Article' file.
namespace Blog_API.Application.Repositories
{
    /// <summary>
    /// Represents an interface for performing write operations related to articles
    /// This interface extends the IWriteRepository<Article> and provides specific write operations for articles
    /// </summary>
    public interface IArticleWriteRepository : IWriteRepository<Article>
    {

    }
}

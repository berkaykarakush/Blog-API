using Blog_API.Domain.Entities;

// This namespace is introduced to resolve naming conflicts between the 'Article' class and 'Article' file.
namespace Blog_API.Application.Repositories
{
    /// <summary>
    /// IArticleReadRepository is an interface used to manage reading operations for article entities
    /// This interfaces implements the IReadRepository<Article> and provides specific reading operations for articles
    /// </summary>
    public interface IArticleReadRepository : IReadRepository<Article>
    {

    }
}

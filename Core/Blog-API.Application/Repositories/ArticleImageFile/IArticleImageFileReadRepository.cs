using Blog_API.Domain.Entities;

// This namespace is introduced to resolve naming conflicts between the ArticleImageFile class and ArticleImageFile file.
namespace Blog_API.Application.Repositories
{
    /// <summary>
    /// Represents an interface for reading operations related to article image files 
    /// This interface extends the IReadRepository<ArticleImageFile> and provides specific operations for article image files
    /// </summary>
    public interface IArticleImageFileReadRepository : IReadRepository<ArticleImageFile>
    {
    }
}

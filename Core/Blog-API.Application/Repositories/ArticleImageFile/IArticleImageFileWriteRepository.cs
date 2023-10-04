using Blog_API.Domain.Entities;

// This namespace is introduced to resolve naming conflicts between the ArticleImageFile class and ArticleImageFile file.
namespace Blog_API.Application.Repositories
{
    /// <summary>
    /// Represents an interface for writing operations related to article image files
    /// This interface extends the IWriteRepository<ArticleImageFile> and provides specific writing operations for article image files
    /// </summary>
    public interface IArticleImageFileWriteRepository : IWriteRepository<ArticleImageFile>
    {
    }
}

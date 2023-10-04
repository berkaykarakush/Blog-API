using Blog_API.Domain.Entities;

// This namespace is introduced to resolve naming conflicts between the Commet class and Comment file.
namespace Blog_API.Application.Repositories
{
    /// <summary>
    /// Represents an interfaces for reading operations related for comments
    /// This interface extends the IReadRepository<Comment> and provides specific reading operations for comments
    /// </summary>
    public interface ICommentReadRepository : IReadRepository<Comment>
    {
    }
}

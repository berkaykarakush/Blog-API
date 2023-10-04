using Blog_API.Domain.Entities;

// This namespace is introduced to resolve naming conflicts between the Commet class and Comment file.
namespace Blog_API.Application.Repositories
{
    /// <summary>
    /// Represents an interfaces for writing operations related for comments
    /// This interfaces extends the IWriteRepository<Comment> and provides specific write operations for comments
    /// </summary>
    public interface ICommentWriteRepository : IWriteRepository<Comment>
    {
    }
}

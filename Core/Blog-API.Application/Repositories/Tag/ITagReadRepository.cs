using Blog_API.Domain.Entities;

// This namespace is introduced to resolve naming conflicts between the Tag class and Tag file.
namespace Blog_API.Application.Repositories
{
    /// <summary>
    /// Represents an interfaces for reading operations related to tags
    /// This interface extends the IReadRepository<Tag> and provides specific reading operations for tags
    /// </summary>
    public interface ITagReadRepository : IReadRepository<Tag>
    {
    }
}

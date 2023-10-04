// This namespace is introduced to resolve naming conflicts between the Tag class and Tag file.
using Blog_API.Domain.Entities;

namespace Blog_API.Application.Repositories
{
    /// <summary>
    /// Represents an interface for writing operations related to tags
    /// This interface extends the IWriteRepository<Tag> and provides specific writing operations for tags
    /// </summary>
    public interface ITagWriteRepository : IWriteRepository<Tag>
    {
    }
}

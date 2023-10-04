// This namespace is introduced to resolve naming conflicts between the File class and File file.
using Blog_API.Domain.Entities;

namespace Blog_API.Application.Repositories
{
    /// <summary>
    /// Represents an interface for writing operations related to files
    /// This interface extends the IWriteRepository<File> and provides specific writing operation for files
    /// </summary>
    public interface IFileWriteRepository : IWriteRepository<Domain.Entities.File>
    {
    }
}

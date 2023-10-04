// This namespace is introduced to resolve naming conflicts between the File class and File file.
namespace Blog_API.Application.Repositories
{
    /// <summary>
    /// Represents an interface for reading operations related to files
    /// This interface extends the IReadRepository<File> and provides specific read operations for files
    /// </summary>
    public interface IFileReadRepository : IReadRepository<Domain.Entities.File>
    {
    }
}

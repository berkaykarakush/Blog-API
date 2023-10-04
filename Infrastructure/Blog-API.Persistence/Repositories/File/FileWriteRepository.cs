using Blog_API.Application.Repositories;
using Blog_API.Persistence.Contexts;

// This namespace is introduced to resolve naming conflicts between the File class and File file.
namespace Blog_API.Persistence.Repositories
{
    /// <summary>
    /// This class represents a specific write repository for the File entity, inheriting from the generic WriteRepository and implementing the IFileWriteRepository interface
    /// </summary>
    public class FileWriteRepository : WriteRepository<Domain.Entities.File>, IFileWriteRepository
    {
        /// <summary>
        /// Constructor that takes an instance of the ApplicationDbContext and calls the base constructor
        /// </summary>
        public FileWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

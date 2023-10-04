using Blog_API.Application.Repositories;
using Blog_API.Persistence.Contexts;

// This namespace is introduced to resolve naming conflicts between the File class and File file.
namespace Blog_API.Persistence.Repositories
{
    /// <summary>
    /// This class represents a specific read repository for the File entity, inheriting from the generic ReadRepository and implenting the IFileReadRepository interface
    /// </summary>
    public class FileReadRepository : ReadRepository<Domain.Entities.File>, IFileReadRepository
    {
        /// <summary>
        /// Constructor that takes an instance of the ApplicationDbContext and calls the base constructor
        /// </summary>
        public FileReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

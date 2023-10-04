using Blog_API.Application.Repositories;
using Blog_API.Domain.Entities;
using Blog_API.Persistence.Contexts;
/// This class represents a specific read repository for the Tag entity, inheriting from the generic ReadRepository and implementing the ITagReadRepository
namespace Blog_API.Persistence.Repositories
{
    /// <summary>
    /// This class represents a specific write repository for the Tag entity, inheriting from the generic WriteRepository and implementing the ITagWriteRepository
    /// </summary>
    public class TagWriteRepository : WriteRepository<Tag>, ITagWriteRepository
    {
        /// <summary>
        /// Constructor that takes an instance of the ApplicationDbContext and calls the base constructor
        /// </summary>
        /// <param name="context"></param>
        public TagWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

// This namespace is introduced to resolve naming conflicts between the Tag class and Tag file.
using Blog_API.Application.Repositories;
using Blog_API.Domain.Entities;
using Blog_API.Persistence.Contexts;

namespace Blog_API.Persistence.Repositories
{
    /// <summary>
    /// This class represents a specific read repository for the Tag entity, inheriting from the generic ReadRepository and implementing the ITagReadRepository
    /// </summary>
    public class TagReadRepository : ReadRepository<Tag>, ITagReadRepository
    {
        /// <summary>
        /// Constructor that takes an instance of the ApplicationDbContext and calls the base constructor
        /// </summary>
        public TagReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

﻿using Blog_API.Application.Repositories;
using Blog_API.Domain.Entities;
using Blog_API.Persistence.Contexts;

// This namespace is introduced to resolve naming conflicts between the Comment class and Comment file.
namespace Blog_API.Persistence.Repositories
{
    /// <summary>
    /// This class represents a specific write repository for the Comment entity, inheriting from the generic ReadRepository and implementing the ICommentWriteRepository interface
    /// </summary>
    public class CommentWriteRepository : WriteRepository<Comment>, ICommentWriteRepository
    {
        /// <summary>
        /// Constructor that takes an instance of the ApplicationDbContext and calls the base constructor
        /// </summary>
        public CommentWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

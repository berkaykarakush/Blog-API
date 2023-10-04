namespace Blog_API.Application.Repositories
{
    /// <summary>
    /// This interface defines the contract for a Unit of Work in the application
    /// </summary>
    public interface IUnitOfWork : IAsyncDisposable
    {
        /// <summary>
        /// Commits the changes made within the unit of work to the underlyin data store
        /// </summary>
        /// <param name="state">A status change indicating whether the records should be saved(default ist true)</param>
        /// <returns>A task representing the asynchronous operation, returning true if the commit successfull, otherwise false</returns>
        Task<bool> Commit(bool state = true);
        // Interface references for Article repository
        public IArticleReadRepository ArticleReadRepository { get; }
        // Interface references for Article repository
        public IArticleWriteRepository ArticleWriteRepository { get; }
        // Interface refernces for ArticleImageFile repository
        public IArticleImageFileReadRepository ArticleImageFileReadRepository { get; }
        // Interface references for ArticleImageFile repository
        public IArticleImageFileWriteRepository ArticleImageFileWriteRepository { get; }
        // Interface references for Comment repository
        public ICommentReadRepository CommentReadRepository { get; }
        // Interfaces references for comment repository
        public ICommentWriteRepository CommentWriteRepository { get; }
        // Interface references for File repository
        public IFileReadRepository FileReadRepository { get; }
        // Interface refernces for File repository
        public IFileWriteRepository FileWriteRepository { get; }
        // Interface references for Tag repository
        public ITagReadRepository TagReadRepository { get; }
        // Interface references for Tag repository
        public ITagWriteRepository TagWriteRepository { get; }
    }
}

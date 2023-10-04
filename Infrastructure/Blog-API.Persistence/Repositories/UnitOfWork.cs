using Blog_API.Application.Repositories;
using Blog_API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore.Storage;

namespace Blog_API.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;


        IDbContextTransaction transaction = null;
        private IArticleReadRepository _articleReadRepository;
        private IArticleWriteRepository _articleWriteRepository;
        private IArticleImageFileReadRepository _articleImageFileReadRepository;
        private IArticleImageFileWriteRepository _articleImageFileWriteRepository;
        private ICommentReadRepository _commentReadRepository;
        private ICommentWriteRepository _commentWriteRepository;
        private IFileReadRepository _fileReadRepository;
        private IFileWriteRepository _fileWriteRepository;
        private ITagReadRepository _tagReadRepository;
        private ITagWriteRepository _tagWriteRepository;
        public UnitOfWork(ApplicationDbContext context, IArticleReadRepository articleReadRepository, IArticleWriteRepository articleWriteRepository, IArticleImageFileReadRepository articleImageFileReadRepository, IArticleImageFileWriteRepository articleImageFileWriteRepository, ICommentReadRepository commentReadRepository, ICommentWriteRepository commentWriteRepository, IFileReadRepository fileReadRepository, IFileWriteRepository fileWriteRepository, ITagReadRepository tagReadRepository, ITagWriteRepository tagWriteRepository)
        {
            _context = context;
            transaction = _context.Database.BeginTransaction();
            _articleReadRepository = articleReadRepository;
            _articleWriteRepository = articleWriteRepository;
            _articleImageFileReadRepository = articleImageFileReadRepository;
            _articleImageFileWriteRepository = articleImageFileWriteRepository;
            _commentReadRepository = commentReadRepository;
            _commentWriteRepository = commentWriteRepository;
            _fileReadRepository = fileReadRepository;
            _fileWriteRepository = fileWriteRepository;
            _tagReadRepository = tagReadRepository;
            _tagWriteRepository = tagWriteRepository;
        }

        public IArticleReadRepository ArticleReadRepository => _articleReadRepository ?? new ArticleReadRepository(_context);

        public IArticleWriteRepository ArticleWriteRepository => _articleWriteRepository ?? new ArticleWriteRepository(_context);

        public IArticleImageFileReadRepository ArticleImageFileReadRepository => _articleImageFileReadRepository ?? new ArticleImageFileReadRepository(_context);

        public IArticleImageFileWriteRepository ArticleImageFileWriteRepository => _articleImageFileWriteRepository ?? new ArticleImageFileWriteRepository(_context);

        public ICommentReadRepository CommentReadRepository => _commentReadRepository ?? new CommentReadRepository(_context);

        public ICommentWriteRepository CommentWriteRepository => _commentWriteRepository ?? new CommentWriteRepository(_context);

        public IFileReadRepository FileReadRepository => _fileReadRepository ?? new FileReadRepository(_context);

        public IFileWriteRepository FileWriteRepository => _fileWriteRepository ?? new FileWriteRepository(_context);

        public ITagReadRepository TagReadRepository => _tagReadRepository ?? new TagReadRepository(_context);

        public ITagWriteRepository TagWriteRepository => _tagWriteRepository ?? new TagWriteRepository(_context);

        public async Task<bool> Commit(bool state = true)
        {
            await _context.SaveChangesAsync();

            if (state)
                await transaction.CommitAsync();
            else
                await transaction.RollbackAsync();

            await DisposeAsync();
            return true;
        }
        public async ValueTask DisposeAsync() => await _context.DisposeAsync();
    }
}

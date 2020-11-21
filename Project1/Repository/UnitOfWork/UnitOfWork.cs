using Project1.DAL.Database;
using Project1.DAL.Entities;
using Project1.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        internal DatabaseContext dbContext;
        public IGenericRepository<User> UserRepository { get; private set; }
        public IGenericRepository<Post> PostRepository { get; private set; }
        public IGenericRepository<PostLike> PostLikeRepository { get; private set; }
        public IGenericRepository<PostComment> PostCommentRepository { get; private set; }
        public IGenericRepository<FollowerRelationship> FollowerRelationshipRepository { get; private set; }
        public IGenericRepository<FollowedRelationship> FollowedRelationshipRepository { get; private set; }
        public IGenericRepository<UserProfile> UserProfileRepository { get; private set; }
        public IGenericRepository<PostCategory> PostCategoryRepository { get; private set; }
        public IGenericRepository<Category> CategoryRepository { get; private set; }



        public UnitOfWork(DatabaseContext context)
        {
            this.dbContext = context;
            InitRepositories();
        }
        private void InitRepositories()
        {
            UserRepository = new GenericRepository<User>(dbContext);
            PostRepository = new GenericRepository<Post>(dbContext);
            PostLikeRepository = new GenericRepository<PostLike>(dbContext);
            PostCommentRepository = new GenericRepository<PostComment>(dbContext);
            FollowerRelationshipRepository = new GenericRepository<FollowerRelationship>(dbContext);
            FollowedRelationshipRepository = new GenericRepository<FollowedRelationship>(dbContext);
            UserProfileRepository = new GenericRepository<UserProfile>(dbContext);
            PostCategoryRepository = new GenericRepository<PostCategory>(dbContext);
            CategoryRepository = new GenericRepository<Category>(dbContext);
        }

        public async Task SaveAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

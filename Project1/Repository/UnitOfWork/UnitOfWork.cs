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
        public IGenericRepository<Post> StatusRepository { get; private set; }
        public IGenericRepository<PostLike> LikeRepository { get; private set; }
        public IGenericRepository<PostComment> CommentRepository { get; private set; }
        public IGenericRepository<FollowingRelationship> FollowRepository { get; private set; }

        

        public UnitOfWork(DatabaseContext context)
        {
            this.dbContext = context;
            InitRepositories();
        }
        private void InitRepositories()
        {
            UserRepository = new GenericRepository<User>(dbContext);
            StatusRepository = new GenericRepository<Post>(dbContext);
            LikeRepository = new GenericRepository<PostLike>(dbContext);
            CommentRepository = new GenericRepository<PostComment>(dbContext);
            FollowRepository = new GenericRepository<FollowingRelationship>(dbContext);
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

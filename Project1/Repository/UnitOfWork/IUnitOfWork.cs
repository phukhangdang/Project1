using Project1.DAL.Entities;
using Project1.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<Post> PostRepository { get; }
        IGenericRepository<PostLike> PostLikeRepository { get; }
        IGenericRepository<PostComment> PostCommentRepository { get; }
        IGenericRepository<FollowingRelationship> FollowingRelationshipRepository { get; }
        IGenericRepository<UserProfile> UserProfileRepository { get; }
        IGenericRepository<PostCategory> PostCategoryRepository { get; }
        IGenericRepository<Category> CategoryRepository { get; }
        Task SaveAsync();
    }
}

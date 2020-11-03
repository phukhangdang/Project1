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
        IGenericRepository<Post> StatusRepository { get; }
        IGenericRepository<PostLike> LikeRepository { get; }
        IGenericRepository<PostComment> CommentRepository { get; }
        IGenericRepository<FollowingRelationship> FollowRepository { get; }
        Task SaveAsync();
    }
}

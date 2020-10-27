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
        IGenericRepository<Status> StatusRepository { get; }
        IGenericRepository<Like> LikeRepository { get; }
        IGenericRepository<Comment> CommentRepository { get; }
        IGenericRepository<Follow> FollowRepository { get; }
        Task SaveAsync();
    }
}

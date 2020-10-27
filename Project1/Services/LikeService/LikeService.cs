using Project1.DAL.Dtos;
using Project1.DAL.Entities;
using Project1.Repository.GenericRepository;
using Project1.Repository.UnitOfWork;
using Project1.Services.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Services.LikeService
{
    public class LikeService : BaseService<Like, LikeDto>, ILikeService
    {
        public LikeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        protected override IGenericRepository<Like> _reponsitory => _unitOfWork.LikeRepository;
    }
}

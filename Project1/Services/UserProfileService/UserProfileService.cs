using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project1.DAL.Dtos;
using Project1.DAL.Entities;
using Project1.Repository.GenericRepository;
using Project1.Repository.UnitOfWork;
using Project1.Services.BaseService;

namespace Project1.Services.UserProfileService
{
    public class UserProfileService : BaseService<UserProfile, UserProfileDto>, IUserProfileService
    {
        public UserProfileService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IGenericRepository<UserProfile> _reponsitory => _unitOfWork.UserProfileRepository;
    }
}

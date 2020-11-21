using Project1.DAL.Dtos;
using Project1.DAL.Entities;
using Project1.Repository.GenericRepository;
using Project1.Repository.UnitOfWork;
using Project1.Services.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Services.FollowedRelationshipService
{
    public class FollowedRelationshipService : BaseService<FollowedRelationship, FollowedRelationshipDto>, IFollowedRelationshipService
    {
        public FollowedRelationshipService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        protected override IGenericRepository<FollowedRelationship> _reponsitory => _unitOfWork.FollowedRelationshipRepository;
    }
}

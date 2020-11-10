using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project1.DAL.Dtos;
using Project1.DAL.Entities;
using Project1.Repository.GenericRepository;
using Project1.Repository.UnitOfWork;
using Project1.Services.BaseService;

namespace Project1.Services.PostCategoryService
{
    public class PostCategoryService : BaseService<PostCategory, PostCategoryDto>, IPostCategoryService
    {
        public PostCategoryService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IGenericRepository<PostCategory> _reponsitory => _unitOfWork.PostCategoryRepository;
    }
}

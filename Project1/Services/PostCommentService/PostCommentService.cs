﻿using Project1.DAL.Dtos;
using Project1.DAL.Entities;
using Project1.Repository.GenericRepository;
using Project1.Repository.UnitOfWork;
using Project1.Services.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Services.PostCommentService
{
    public class PostCommentService : BaseService<PostComment, PostCommentDto>, IPostCommentService
    {
        public PostCommentService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IGenericRepository<PostComment> _reponsitory => _unitOfWork.PostCommentRepository;
    }
}

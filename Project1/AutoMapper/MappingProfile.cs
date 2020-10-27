using AutoMapper;
using Project1.DAL.Dtos;
using Project1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Entity to Dto
            CreateMap<User, UserDto>();
            CreateMap<Status, StatusDto>();
            CreateMap<Like, LikeDto>();
            CreateMap<Follow, FollowDto>();
            CreateMap<Comment, CommentDto>();

            //Dto to Entity
            CreateMap<UserDto, User>();
            CreateMap<StatusDto, Status>();
            CreateMap<LikeDto, Like>();
            CreateMap<FollowDto, Follow>();
            CreateMap<CommentDto, Comment>();

        }
    }
}

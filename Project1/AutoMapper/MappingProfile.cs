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
            CreateMap<Post, PostDto>();
            CreateMap<PostLike, PostLikeDto>();
            CreateMap<FollowerRelationship, FollowerRelationshipDto>();
            CreateMap<PostComment, PostCommentDto>();
            CreateMap<PostCategory, PostCategoryDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<UserProfile, UserProfileDto>();

            //Dto to Entity
            CreateMap<UserDto, User>();
            CreateMap<PostDto, Post>();
            CreateMap<PostLikeDto, PostLike>();
            CreateMap<FollowerRelationshipDto, FollowerRelationship>();
            CreateMap<PostCommentDto, PostComment>();
            CreateMap<CategoryDto, Category>();
            CreateMap<PostCategoryDto, PostCategory>();
            CreateMap<UserProfileDto, UserProfile>();

        }
    }
}

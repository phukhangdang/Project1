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
            CreateMap<Role, RoleDto>();
            CreateMap<Follow, FollowDto>();
            CreateMap<UserAccount, UserAccountDto>();

            //Dto to Entity
            CreateMap<UserDto, User>();
            CreateMap<StatusDto, Status>();
            CreateMap<RoleDto, Role>();
            CreateMap<FollowDto, Follow>();
            CreateMap<UserAccountDto, UserAccount>();

        }
    }
}

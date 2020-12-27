using AutoMapper;
using Project1.DAL.Dtos;
using Project1.DAL.Entities;
using Project1.Repository.GenericRepository;
using Project1.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Services.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoginService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<UserDto> LoginAsync(UserDto Dto)
        {
            IEnumerable<User> Users = await _unitOfWork.UserRepository.Get(-1, 0);
            foreach (var Entity in Users)
            {
                if (Entity.UserName == Dto.UserName && Entity.Password == Dto.Password) return EntityToDto(Entity, Dto);
            }
            return Dto;
        }
        protected User DtoToEntity(UserDto dto, User entity)
        {
            return Mapper.Map(dto, entity);
        }
        protected UserDto EntityToDto(User entity, UserDto dto)
        {
            return Mapper.Map(entity, dto);
        }

    }
}

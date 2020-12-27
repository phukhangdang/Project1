using Project1.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Services.LoginService
{
    public interface ILoginService
    {
        public Task<UserDto> LoginAsync(UserDto Dto);
    }
}

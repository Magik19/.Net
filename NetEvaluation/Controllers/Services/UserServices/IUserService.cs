using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetEvaluation.Controllers.Dto.User;

namespace NetEvaluation.Controllers.Services.UserServices
{
    public interface IUserService
    {
        Task<ServiceResponse<List<GetUserDto>>> GetAllUsers();
        Task<ServiceResponse<GetUserDto>> GetUserById(int id);

        Task<ServiceResponse<List<GetUserDto>>> AddUser(AddUserDto newUser);
    }
}
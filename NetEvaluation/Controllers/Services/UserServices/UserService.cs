using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetEvaluation.Controllers.Dto.User;

namespace NetEvaluation.Controllers.Services.UserServices
{
    public class UserService : IUserService
    {

        private static List<UserController> Users = new List<UserController> {
            new User(),
            new User{ UserId = 1, Name = "Gabo"}
        };
        public async Task<ServiceResponse<List<GetUserDto>>> AddUser(AddUserDto newUser)
        {
            var ServiceResponse = new ServiceResponse<List<GetUserDto>>();
            Users.Add(newUser);
            ServiceResponse.Data = Users;
            return ServiceResponse;        
        }

        public async Task<ServiceResponse<List<GetUserDto>>> GetAllUsers()
        {
            return new ServiceResponse<List<GetUserDto>>{ Data = Users};
        }

        public async Task<ServiceResponse<GetUserDto>> GetUserById(int id)
        {
            var serviceResponse = new ServiceResponse<GetUserDto>();
            var User = Users.FirstOrDefault(u => u.UserId == id);
            serviceResponse.Data = User;
            return serviceResponse;
        }
    }
}
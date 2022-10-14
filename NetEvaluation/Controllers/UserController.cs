using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetEvaluation.Controllers.Dto.User;
using NetEvaluation.Controllers.Services.UserServices;

namespace NetEvaluation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _UserService;
        
        public UserController(IUserService userService)
        {
            _UserService = userService;
            
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetUserDto>>>> Get()
        {
            return Ok(await _UserService.GetAllUsers());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> GetSingle(int userid)
        {
            return Ok(await _UserService.GetUserById(id));
        }


        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetUserDto>>> AddUser(AddUserDto newUser)
        {
            return Ok(await _UserService.AddUser(newUser));
        }

    }
}
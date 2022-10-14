using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetEvaluation.Controllers.Dto.User
{
    public class AddUserDto
    {
        public string Name { get; set; } = "Gabo";
        public UserType Class { get; set; } = UserTypeclass.Buyer;
        public string Email { get; set; }
        public int Phone { get; set; }
    }
}
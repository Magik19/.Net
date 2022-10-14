using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetEvaluation.bin.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; } = "Gabo";
        public UserType Class { get; set; } = UserTypeclass.Buyer;
        public string Email { get; set; }
        public int Phone { get; set; }
    }
}
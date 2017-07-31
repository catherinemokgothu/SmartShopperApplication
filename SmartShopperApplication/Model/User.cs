using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartShopperApplication.Model
{
    public class User
    {
        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public System.DateTime LastLoggentInDate { get; set; }
        public string IsActive { get; set; }
    }
}

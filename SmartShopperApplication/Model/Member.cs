using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartShopperApplication.Model
{
    public class Member
    {
        public int MemberId { get; set; }
        public int UserId { get; set; }
        public int MemberStatusId { get; set; }
        public System.DateTime LastLoggentInDate { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

    }
}

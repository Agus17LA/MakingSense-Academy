using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones.Model
{
    public class AuthenticatedUser
    {
        public String token { get; set; }
        public String username { get; set; }
        public AuthenticatedUser(string token, string username)
        {
            this.token = token;
            this.username = username;
        }

    }
}

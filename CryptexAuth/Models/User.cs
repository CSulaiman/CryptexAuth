using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptexAuth.Models
{
    public class User
    {
        public User()
        {
            Exchanges = new List<UserExchange>();
        }
        public string UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Level { get; set; }
        public List<UserExchange> Exchanges { get; set; }
    }
}

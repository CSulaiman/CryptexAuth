using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptexAuth.Models
{
    public class UserExchange
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public string MdWsUrl { get; set; }
        public string TrdWsUrl { get; set; }
        public string RestUrl { get; set; }
        public string PassPhrase { get; set; }
        public List<Product> Products { get; set; } // name it product?
    }
}

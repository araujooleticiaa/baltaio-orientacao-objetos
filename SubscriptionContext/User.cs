using balta.BaltaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balta.SubscriptionContext
{
    public class User : BaseContext
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

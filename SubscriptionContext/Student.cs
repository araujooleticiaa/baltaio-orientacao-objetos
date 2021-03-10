using balta.BaltaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balta.SubscriptionContext
{
    public class Student : BaseContext
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User user { get; set; }
        public IList<Subscription> Subscription { get; set; }

        public bool IsPremiun => Subscription.Any(x => !x.IsInactive);
    }
}


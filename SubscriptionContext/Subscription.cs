using balta.BaltaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balta.SubscriptionContext
{
    public class Subscription : BaseContext
    {
        public Plan plan { get; set; }
        public DateTime? EndTime { get; set; }

        public bool IsInactive => EndTime <= DateTime.Now;
    }
}

using balta.BaltaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balta.SubscriptionContext
{
    public class Plan : BaseContext
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}

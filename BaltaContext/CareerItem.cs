using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balta.BaltaContext
{
    public class CareerItem
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Couser Couser { get; set; }
    }
}

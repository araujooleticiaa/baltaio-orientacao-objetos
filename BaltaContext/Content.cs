using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balta.BaltaContext
{
    public abstract class Content : BaseContext
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }

        public string Title { get; set; }
        public string Url { get; set; }

    }
}

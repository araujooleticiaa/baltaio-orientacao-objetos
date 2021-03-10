using balta.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balta.BaltaContext
{
    public abstract class BaseContext : Notifiable
    {
        public BaseContext()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }

    
}

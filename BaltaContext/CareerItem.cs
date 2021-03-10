using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balta.BaltaContext
{
    public class CareerItem : BaseContext
    {
        public CareerItem(int order, string title, string description, Couser couser)
        {
            if(couser == null)
            {
                Add(new NotificationContext.Notification("Error", "O Curso não pode ser vazio."));
            }

            Order = order;
            Title = title;
            Description = description;
            Couser = couser;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Couser Couser { get; set; }
    }
}

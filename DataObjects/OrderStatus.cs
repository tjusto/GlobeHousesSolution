using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjects
{
    public class OrderStatus
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; } //Undefined, Submited, Pending, Closed, Expired
    }
}

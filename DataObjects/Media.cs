using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjects
{
    public class Media
    {
        public virtual Guid Id { get; set; }
        public virtual long HouseId { get; set; }
        public virtual string Description { get; set; }
        public virtual bool Default { get; set; }
        public virtual bool Featured { get; set; }
    }
}

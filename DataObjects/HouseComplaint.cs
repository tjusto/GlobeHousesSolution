using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjects
{
    public class HouseComplaint
    {
        public virtual long Id { get; set; }
        public virtual long HouseId { get; set; }
        public virtual string Description { get; set; }
        public virtual bool HouseOwnerRead { get; set; }
        public virtual bool AdminRead { get; set; }
    }
}

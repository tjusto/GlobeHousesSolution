using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataObjects.Common;

namespace DataObjects
{
    public class HouseBase
    {
        public virtual long Id { get; set; }
        public virtual long CostumerId { get; set; }
        public virtual string Name { get; set; }
        /// <summary>
        /// Costumer can put the house public visible or not
        /// </summary>
        public virtual bool Active { get; set; }
        /// <summary>
        /// House is not public by admin order
        /// </summary>
        public virtual bool Blocked { get; set; }
        public virtual DateTime Created { get; set; }
    }
}

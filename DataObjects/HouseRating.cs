using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjects
{
    public class HouseRating
    {
        public virtual long Id { get; set; }
        public virtual long HouseId { get; set; }
        // Rating overall 
        public virtual int GreatTotal { get; set; }
        public virtual int GoodTotal { get; set; }
        public virtual int RegularTotal { get; set; }
        public virtual int InsufficientTotal { get; set; }
        public virtual int BadTotal { get; set; }
        /// <summary>
        /// Comments and individual rating
        /// </summary>
        public virtual ICollection<HouseComment> Comments { get; set; }
    }
}

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DataObjects.Common;

namespace DataObjects
{
    public class Costumer : CostumerBase
    {
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string Province { get; set; }
        public virtual string ZipCode { get; set; }
        public virtual Country County { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual Credits Credits { get; set; }
        public ICollection<House> Houses { get; set; }

        // Rating overall 
        public virtual int GreatTotal { get; set; }
        public virtual int GoodTotal { get; set; }
        public virtual int RegularTotal { get; set; }
        public virtual int InsufficientTotal { get; set; }
        public virtual int BadTotal { get; set; }

        /// <summary>
        /// Comments and individual rating
        /// </summary>
        public virtual ICollection<Comment> Comments { get; set; }

    }
}

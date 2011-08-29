using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjects
{
    public abstract class Order
    {
        public virtual Guid Id { get; set; }
        public virtual string Description { get; set; }
        public virtual OrderStatus Status { get; set; }
        public virtual DateTime Creation { get; set; }
        public virtual ICollection<CreditsTransaction> CreditsTransactions { get; set; }
    }
}

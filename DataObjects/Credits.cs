using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataObjects
{
    public class Credits
    {
        public virtual int Id { get; set; }
        [Key]
        public virtual int CostumerId { get; set; }
        public virtual long Total { get; set; }
        public virtual long Spend { get; set; }
        public virtual ICollection<CreditsTransaction> Transactions { get; set; }
    }
}

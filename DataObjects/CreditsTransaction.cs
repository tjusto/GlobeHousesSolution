using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataObjects
{
    public class CreditsTransaction 
    {
        public virtual long Id { get; set; }
        [Key]
        public virtual long ToCostumer { get; set; }
        public virtual long From { get; set; }
        public virtual CreditsOrderType Type { get; set; }
        public virtual int Value { get; set; }
        public virtual DateTime CreationDate { get; set; }
    }
}

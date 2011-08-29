using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjects
{
    /// <summary>
    /// Credits bought, transfered or debit, admin credit or debit, etc
    /// </summary>
    public class CreditsOrderType
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; } 
    }
}

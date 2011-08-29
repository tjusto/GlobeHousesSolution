using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataObjects
{
    public class HouseComment : Comment
    {
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        /// <summary>
        /// if CreditsPerDaySuggested == 0 racio day/credits OK
        /// </summary>
        public virtual int CreditsPerDaySuggested { get; set; }
    }
}

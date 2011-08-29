using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataObjects.Common;

namespace DataObjects
{
    // TODO: for banners and highlights
    public class Campaigns
    {
        public virtual int Id { get; set; }
        public virtual ICollection<Translation> Teaser { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDat { get; set; }
       
    }
}
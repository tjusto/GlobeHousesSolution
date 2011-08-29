using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjects
{
    public class OrderHouseReservation : Order
    {
        public virtual CostumerBase FromCostumer { get; set; } //Costumer that submited the order
        public virtual House House { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
    }
}

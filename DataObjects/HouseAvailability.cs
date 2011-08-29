using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjects
{
    /// <summary>
    /// DATAS DE DISPONIBILIZAÇÃO DA SUA CASA E PONTUAÇÃO (VEJA COMO FUNCIONA):
    /// </summary>
    public class HouseAvailability
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual int CreditValue { get; set; }
    }
}

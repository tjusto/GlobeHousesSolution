using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataObjects
{
    /// <summary>
    /// Point of Interest
    /// a) DISTÂNCIA AO LOCAL DE INTERESSE (PRAIA/ CENTRO DE SKY/ ETC)__ METROS.
    /// b) PRINCIPAIS ATRACÇÕES LOCAIS DATA___/__/___
    /// </summary>
    public class POI
    {
        public virtual Guid Id { get; set; }
        [Key]
        public virtual long HouseId { get; set; }
        public string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal DistanceToHouse { get; set; }
        public virtual float Latitude { get; set; }
        public virtual float Longitude { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndTime { get; set; }
        /// <summary>
        /// PRINCIPAIS ATRACÇÕES LOCAIS (should have StartDate and EndTime filled
        /// </summary>
        public virtual bool Attraction { get; set; }
    }
}

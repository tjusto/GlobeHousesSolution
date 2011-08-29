using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataObjects
{
    public class Comment
    {
        public virtual Guid Id { get; set; }
        [Key]
        public virtual long FromCostumerId { get; set; }
        [Key]
        public virtual long ToHouseId { get; set; }
        public virtual string Description { get; set; }
        /// <summary>
        /// 1 => Mau
        /// 2 => Deficiente
        /// 3 => Regular
        /// 4 => Bom
        /// 5 => Mtº Bom
        /// </summary>
        public virtual short Score { get; set; }
    }
}

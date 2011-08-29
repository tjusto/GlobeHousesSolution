using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace DataObjects.ContextDb
{
    public class GlobeHousesDbContext : 
        : DbContext,
        ICostumer
    {
        /// Costumer
        public DbSet<CostumerBase> CostumersBase { get; set; }
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<House> Houses { get; set; }



    }
}

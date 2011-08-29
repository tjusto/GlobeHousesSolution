using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataObjects.ContextDb
{
    interface IGlobeHousesDbContext : IDisposable
    {
        int SaveChanges();
    }
}

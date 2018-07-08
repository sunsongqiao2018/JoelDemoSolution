using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PlaystationStore.Models
{
    public class PSGameStoreDbContext : DbContext 
    {
        public DbSet<Game> Games { get; set; }
    }
}
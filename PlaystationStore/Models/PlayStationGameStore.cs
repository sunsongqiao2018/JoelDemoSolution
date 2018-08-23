using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaystationStore.Models
{
    public class PSGameStoreDbContext : DbContext 
    {
        public PSGameStoreDbContext() {
            Database.Log = s => Debug.WriteLine(s);

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
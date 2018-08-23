using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaystationStore.Models.Repositories
{
    public class ProducerRepository : Repository<Producer>
    {
        public List<Producer> Get(string name)
        {
            return DbSet.Where(a => a.producerName.Contains(name)).ToList();
        }
    }
}
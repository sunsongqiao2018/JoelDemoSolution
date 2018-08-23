using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaystationStore.Models.Repositories
{
    public class GameRepository : Repository<Game>
    {
        public List<Game> Get(string name)
        {
            return DbSet.Where(a => a.gameName.Contains(name)).ToList();
        }
    }
}
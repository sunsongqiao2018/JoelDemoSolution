using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PlaystationStore.Models
{
    public class PlaystationGameStoreDataInitializer : DropCreateDatabaseAlways<PSGameStoreDbContext>
    {
        
        protected override void Seed(PSGameStoreDbContext context)
        {
            Game game = new Game { gameName = "God of War" }; //one way to add data

            context.Producers.Add(new Producer { producerName = "Naughty Dogs", producerType = "Market Leader" });

            Producer producer = new Producer { producerName = "Santa Monicas", producerType = "Market Leader" };
            context.Games.Add(game);
            context.Games.Add(new Game { gameName = "Uncharted 4",producer = producer }); //another way
                                                                                          //base.Seed(context);

            context.Games.Add(new Game {
                producer = context.Producers.Add(new Producer { producerName = "Game Freak" }),
                gameName = "Pokemon ",
                gameGeneric = "Adventure"
            });

            context.SaveChanges();
        }
    }
}
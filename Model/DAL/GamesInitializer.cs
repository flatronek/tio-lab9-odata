using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class GamesInitializer : DropCreateDatabaseIfModelChanges<GamesContext>
    {
        protected override void Seed(GamesContext context)
        {
            var games = new List<Game>
            {
                new Game() {Id = 1, AgeRate = 12, CreatorCompany = "buggysoft", Title = "tomb raider", Year = 1999 },
                new Game() {Id = 2, AgeRate = 16, CreatorCompany = "buggysoft", Title = "asasyni z pustyni", Year = 2000 }
            };
            games.ForEach(s => context.Games.Add(s));
            context.SaveChanges();

            var stores = new List<Store>
            {
                new Store() { Id = 1, Address = "krakow 1", Name = "kosmiczne gry"},
                new Store() { Id = 2, Address = "warszawa 2", Name = "pro gaming shop"}
            };
            stores.ForEach(a => context.Stores.Add(a));
            context.SaveChanges();
        }
    }
}

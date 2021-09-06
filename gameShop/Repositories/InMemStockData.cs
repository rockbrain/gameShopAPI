using gameRock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameRock.Repositories
{
    public class InMemStockData : IInMemStockData
    {
        private readonly List<Games> games = new()
        {
            new Games { Id = Guid.NewGuid(), Title = "Fifa 22", Price = 65, ReleaseDate = DateTimeOffset.UtcNow },
            new Games { Id = Guid.NewGuid(), Title = "Call of Duty", Price = 45, ReleaseDate = DateTimeOffset.UtcNow },
            new Games { Id = Guid.NewGuid(), Title = "Battle Field", Price = 34, ReleaseDate = DateTimeOffset.UtcNow },
            new Games { Id = Guid.NewGuid(), Title = "Warface", Price = 5, ReleaseDate = DateTimeOffset.UtcNow }
        };
        public IEnumerable<Games> GetGames()
        {
            return games;
        }
        public Games GetGame(Guid id)
        {
            return games.Where(game => game.Id == id).SingleOrDefault();
        }
      
    }
}

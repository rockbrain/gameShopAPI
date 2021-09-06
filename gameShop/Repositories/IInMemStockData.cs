using gameRock.Models;
using System;
using System.Collections.Generic;

namespace gameRock.Repositories
{
    public interface IInMemStockData
    {

        Games GetGame(Guid id);
        IEnumerable<Games> GetGames();
        
    }
}
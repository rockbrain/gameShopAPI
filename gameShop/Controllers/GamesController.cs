using gameRock.Models;
using gameRock.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameRock.Controllers
{
    [Route("Games")]
    [ApiController]
    
    public class GamesController : ControllerBase
    {
        
        private readonly InMemStockData inMemStockData;
        public GamesController()
        {
            inMemStockData = new InMemStockData();
        }
        [HttpGet]
        public IEnumerable<Games> GetGames()
        {
            var Games = inMemStockData.GetGames();
            return Games;
        }
    }
}

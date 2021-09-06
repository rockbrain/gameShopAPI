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

        private readonly IInMemStockData inMemStockData;
        public GamesController(IInMemStockData inMemStockData)
        {
           this.inMemStockData = inMemStockData;
        }
        [HttpGet]
        public IEnumerable<Games> GetGames()
        {
            var Games = inMemStockData.GetGames();
            return Games;
        }
        //Get Games By Id
        
        [HttpGet("{id}")]
        public ActionResult<Games> GetGame(Guid id)
        {
            var game = inMemStockData.GetGame(id);

            if (game is null)
            {
                return NotFound();

            }
            return Ok(game);
        }


        

    }
}

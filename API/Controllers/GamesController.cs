using System.Collections.Generic;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private IGameService GameService;

        public GamesController(IGameService gameService) => this.GameService = gameService;

        // GET api/games
        [HttpGet]
        public ActionResult<IEnumerable<Game>> GetAll()
        {
            IEnumerable<Game> games = GameService.GetAll();
            if (games.Any())
            {
                return Ok(games);
            }

            return NoContent();
        }

        // GET api/games/5
        [HttpGet("{gameId}")]
        public ActionResult<Game> GetById(long gameId)
        {
            try
            {
                Game game = GameService.GetById(gameId);

                if (game != null)
                {
                    return Ok(game);
                }

                return NoContent();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // POST api/games
        [HttpPost]
        public ActionResult<int> Post([FromBody] Game game)
        {
            try
            {
                return Ok(GameService.Add(game));
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT api/games/5
        [HttpPut("{gameId}")]
        public ActionResult<int> Put(int gameId, [FromBody] Game game)
        {
            try
            {
                game.GameId = gameId;
                return Ok(GameService.Update(game));
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE api/games/5
        [HttpDelete("{gameId}")]
        public ActionResult<bool> Remove(int gameId)
        {
            try
            {
                return Ok(GameService.Remove(gameId));
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}

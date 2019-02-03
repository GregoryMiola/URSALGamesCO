using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    /// <summary>
    /// Controller of games
    /// </summary>
    [Route("api/[controller]")]
    [EnableCors("URSALGamesCO")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        #region Property

        /// <summary>
        /// Property of game service
        /// </summary>
        private IGameService GameService;

        #endregion Property

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="gameService">Game service</param>
        public GamesController(IGameService gameService) => this.GameService = gameService;

        #endregion Ctor

        #region Methods

        /// <summary>
        /// Endpoint for get all games
        /// </summary>
        /// <returns>Response with list of games</returns>
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

        /// <summary>
        /// Endpoint for get game by id
        /// </summary>
        /// <param name="gameId">Game identifier</param>
        /// <returns>Response with specific game</returns>
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
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Endpoint for add game
        /// </summary>
        /// <param name="game">Game to add</param>
        /// <returns>Response of process</returns>
        [HttpPost]
        public ActionResult<int> Post([FromBody] Game game)
        {
            try
            {
                return Ok(GameService.Add(game));
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Conflict(ex.Message);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Endpoint for update game
        /// </summary>
        /// <param name="gameId">Game identifier</param>
        /// <param name="game">Game to update</param>
        /// <returns>Response of process</returns>
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
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Endpoint for delete game
        /// </summary>
        /// <param name="gameId">Game to delete</param>
        /// <returns>Response of process</returns>
        [HttpDelete("{gameId}")]
        public ActionResult<bool> Remove(int gameId)
        {
            try
            {
                return Ok(GameService.Remove(gameId));
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion Methods
    }
}

using Domain.DTOs;
using Domain.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    /// <summary>
    /// Controller of game results
    /// </summary>
    [Route("~/api/gameResult")]
    [EnableCors("URSALGamesCO")]
    [ApiController]
    public class GameResultController : ControllerBase
    {
        #region Property

        /// <summary>
        /// Property of game results service
        /// </summary>
        private IGameResultService GameResultService;

        #endregion Property

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="gameResultService">Game results service</param>
        public GameResultController(IGameResultService gameResultService) => this.GameResultService = gameResultService;

        #endregion Ctor

        #region Methods

        /// <summary>
        /// Endpoint for update game results
        /// </summary>
        /// <param name="results">List of game results</param>
        /// <returns>Response of update process</returns>
        [HttpPut]
        public ActionResult<bool> PutGameResults([FromBody] List<GameResultDTO> results)
        {
            try
            {
                return Ok(GameResultService.UpdateResults(results));
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Endpoint for get list of games
        /// </summary>
        /// <returns>Response with list of games</returns>
        [HttpGet("getListGames")]
        public ActionResult<List<long>> GetListGames()
        {
            return Ok(GameResultService.GetGamesList());
        }

        /// <summary>
        /// Endpoint for get game results
        /// </summary>
        /// <param name="gameId">Game identifier</param>
        /// <returns>Response with list of game results</returns>
        [HttpGet("getResults/{gameId}")]
        public ActionResult<LeaderboardDTO> GetGameResults(int gameId)
        {
            return Ok(GameResultService.GetGamesResultList(gameId));
        }

        /// <summary>
        /// Endpoint for get the results of users based on the number of games performed
        /// </summary>
        /// <returns>List of most played users</returns>
        [HttpGet("getResults/byGamePlayed")]
        public ActionResult<ResultsGamesPlayedDTO> GetResultsByGamePlayed()
        {
            return Ok(GameResultService.GetResultsByGamePlayed());
        }

        #endregion Methods
    }
}
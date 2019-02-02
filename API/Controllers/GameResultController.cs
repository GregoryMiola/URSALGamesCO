using Domain.DTOs;
using Domain.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("~/api/gameResult")]
    [EnableCors("URSALGamesCO")]
    [ApiController]
    public class GameResultController : ControllerBase
    {
        private IGameResultService GameResultService;

        public GameResultController(IGameResultService gameResultService) => this.GameResultService = gameResultService;

        [HttpPut]
        public ActionResult<bool> Put([FromBody] List<GameResultDTO> results)
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

        [HttpGet("getListGames")]
        public ActionResult<List<long>> GetResults()
        {
            return Ok(GameResultService.GetGamesList());
        }

        [HttpGet("getResults/{gameId}")]
        public ActionResult<LeaderboardDTO> GetGameResults(int gameId)
        {
            return Ok(GameResultService.GetGamesResultList(gameId));
        }

        [HttpGet("getResults/byGamePlayed")]
        public ActionResult<ResultsGamesPlayedDTO> GetResultsByGamePlayed()
        {
            return Ok(GameResultService.GetResultsByGamePlayed());
        }
    }
}
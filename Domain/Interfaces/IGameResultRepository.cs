using System.Collections.Generic;
using Domain.DTOs;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IGameResultRepository : IBaseRepository<GameResult>
    {
        GameResult GetResult(long gameId, long playerId);
        List<long> GetGamesList();
        List<GameResult> GetGameResultList(int gameId);
        List<ResultsGamesPlayedDTO> GetResultsByGamePlayed();
    }
}

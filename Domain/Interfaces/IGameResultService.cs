using System.Collections.Generic;
using Domain.DTOs;

namespace Domain.Interfaces
{
    public interface IGameResultService
    {
        bool UpdateResults(List<GameResultDTO> results);
        List<long> GetGamesList();
        List<LeaderboardDTO> GetGamesResultList(int gameId);
        List<ResultsGamesPlayedDTO> GetResultsByGamePlayed();
    }
}

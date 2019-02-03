using System.Collections.Generic;
using Domain.DTOs;

namespace Domain.Interfaces
{
    /// <summary>
    /// Interface of games result service
    /// </summary>
    public interface IGameResultService
    {
        /// <summary>
        /// Service responsible for update game results of users
        /// </summary>
        /// <param name="results">List of game results</param>
        /// <returns>If you have updated return 1, if 0 is failed</returns>
        bool UpdateResults(List<GameResultDTO> results);
        /// <summary>
        /// Service responsible for get List of games
        /// </summary>
        /// <returns>List of games</returns>
        List<long> GetGamesList();
        /// <summary>
        /// Service responsible for get results of a specific game
        /// </summary>
        /// <param name="gameId">Game identifier</param>
        /// <returns>List of game results</returns>
        List<LeaderboardDTO> GetGamesResultList(int gameId);
        /// <summary>
        /// Service responsible for get the results of users based on the number of games performed
        /// </summary>
        /// <returns>List of most played users</returns>
        List<ResultsGamesPlayedDTO> GetResultsByGamePlayed();
    }
}

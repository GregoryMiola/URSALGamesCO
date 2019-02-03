using System.Collections.Generic;
using Domain.DTOs;
using Domain.Models;

namespace Domain.Interfaces
{
    /// <summary>
    /// Interface of Repository for result of the games played
    /// </summary>
    public interface IGameResultRepository : IBaseRepository<GameResult>
    {
        /// <summary>
        /// Method responsible for fetching a user's record in a game
        /// </summary>
        /// <param name="gameId">Game identifier</param>
        /// <param name="playerId">Player identifier</param>
        /// <returns>In-game user registration</returns>
        GameResult GetResult(long gameId, long playerId);
        /// <summary>
        /// Method responsible for fetching games 
        /// </summary>
        /// <returns>List of games identifier</returns>
        List<long> GetGamesList();
        /// <summary>
        /// Method responsible for fetching results of a specific game
        /// </summary>
        /// <param name="gameId">Game identifier</param>
        /// <returns>List of results of a game</returns>
        List<GameResult> GetGameResultList(int gameId);
        /// <summary>
        /// Method responsible for searching the results of users based on the number of games performed
        /// </summary>
        /// <returns>List of most played users</returns>
        List<ResultsGamesPlayedDTO> GetResultsByGamePlayed();
    }
}

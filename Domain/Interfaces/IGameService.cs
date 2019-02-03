using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    /// <summary>
    /// Interface of game service
    /// </summary>
    public interface IGameService
    {
        /// <summary>
        /// Service responsible for return all games
        /// </summary>
        /// <returns>List of games</returns>
        IEnumerable<Game> GetAll();
        /// <summary>
        /// Service responsible for get a specific game
        /// </summary>
        /// <param name="gameId">Game identifier</param>
        /// <returns>Specific game based on your identifier</returns>
        Game GetById(long gameId);
        /// <summary>
        /// Service responsible for add a new game
        /// </summary>
        /// <param name="game">Game being added</param>
        /// <returns>If you have added return 1, if 0 is failed</returns>
        long Add(Game game);
        /// <summary>
        /// Service responsible for update a game
        /// </summary>
        /// <param name="game">Game being updated</param>
        /// <returns>If you have updated return 1, if 0 is failed</returns>
        long Update(Game game);
        /// <summary>
        /// Service responsible for delete a game
        /// </summary>
        /// <param name="gameId">Game identifier</param>
        /// <returns>Boolean for process of the delete</returns>
        bool Remove(long gameId);
    }
}

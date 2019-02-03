using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;

namespace Service.Services
{
    /// <summary>
    /// Service of games
    /// </summary>
    public class GameService : IGameService
    {
        #region Property

        /// <summary>
        /// Property of game repository
        /// </summary>
        private IGameRepository GameRepository;

        #endregion Property

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="gameRepository">Repository of games entity</param>
        public GameService(IGameRepository gameRepository) => this.GameRepository = gameRepository;

        #endregion Ctor

        #region Methods

        /// <summary>
        /// Service responsible for return all games
        /// </summary>
        /// <returns>List of games</returns>
        public IEnumerable<Game> GetAll()
        {
            return GameRepository.GetAll();
        }

        /// <summary>
        /// Service responsible for get a specific game
        /// </summary>
        /// <param name="gameId">Game identifier</param>
        /// <returns>Specific game based on your identifier</returns>
        public Game GetById(long gameId)
        {
            return GameRepository.GetById(gameId);
        }

        /// <summary>
        /// Service responsible for add a new game
        /// </summary>
        /// <param name="game">Game being added</param>
        /// <returns>If you have added return 1, if 0 is failed</returns>
        public long Add(Game game)
        {
            return GameRepository.Add(game);
        }

        /// <summary>
        /// Service responsible for update a game
        /// </summary>
        /// <param name="game">Game being updated</param>
        /// <returns>If you have updated return 1, if 0 is failed</returns>
        public long Update(Game game)
        {
            return GameRepository.Update(game);
        }

        /// <summary>
        /// Service responsible for delete a game
        /// </summary>
        /// <param name="gameId">Game identifier</param>
        /// <returns>Boolean for process of the delete</returns>
        public bool Remove(long gameId)
        {
            return GameRepository.Remove(gameId);
        }

        #endregion Methods
    }
}

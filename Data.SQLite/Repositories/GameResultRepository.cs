using Data.SQLite.Context;
using Domain.DTOs;
using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Data.SQLite.Repositories
{
    /// <summary>
    /// Repository of result of the games played
    /// </summary>
    public class GameResultRepository : BaseRepository<GameResult>, IGameResultRepository
    {
        #region Property

        /// <summary>
        /// Property of context of the database application
        /// </summary>
        private URSALGamesCOContext Context;

        #endregion Property

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="context">Context of database application</param>
        public GameResultRepository(URSALGamesCOContext context) : base(context)
        {
            Context = context;
        }

        #endregion Ctor

        #region Methods

        /// <summary>
        /// Method responsible for fetching a user's record in a game
        /// </summary>
        /// <param name="gameId">Game identifier</param>
        /// <param name="playerId">Player identifier</param>
        /// <returns>In-game user registration</returns>
        public GameResult GetResult(long gameId, long playerId)
        {
            return Context.GameResults.Where(gr => gr.GameId == gameId && gr.PlayerId == playerId).FirstOrDefault();
        }

        /// <summary>
        /// Method responsible for fetching games 
        /// </summary>
        /// <returns>List of games identifier</returns>
        public List<long> GetGamesList()
        {
            return Context.GameResults.Select(gr => gr.GameId).Distinct().OrderBy(gr => gr).ToList();
        }

        /// <summary>
        /// Method responsible for fetching results of a specific game
        /// </summary>
        /// <param name="gameId">Game identifier</param>
        /// <returns>List of results of a game</returns>
        public List<GameResult> GetGameResultList(int gameId)
        {
            return Context.GameResults.Where(gr => gr.GameId == gameId).Take(100).OrderByDescending(gr => gr.Win).ToList();
        }

        /// <summary>
        /// Method responsible for searching the results of users based on the number of games performed
        /// </summary>
        /// <returns>List of most played users</returns>
        public List<ResultsGamesPlayedDTO> GetResultsByGamePlayed()
        {
            return Context.GameResults
                .GroupBy(gr => gr.PlayerId)
                .Select(gr => new ResultsGamesPlayedDTO { PlayerId = gr.Key, GamesPlayed = gr.Select(b => b.GameId).Count() })
                .OrderByDescending(r => r.GamesPlayed).ToList();
        }

        #endregion Methods
    }
}

using Domain.DTOs;
using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;

namespace Service.Services
{
    /// <summary>
    /// Service of games result
    /// </summary>
    public class GameResultService : IGameResultService
    {
        #region Property

        /// <summary>
        /// Property of games result repository
        /// </summary>
        private IGameResultRepository GameResultRepository;

        #endregion Property

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="gameResultRepository">Repository of games result entity</param>
        public GameResultService(IGameResultRepository gameResultRepository) => this.GameResultRepository = gameResultRepository;

        #endregion Ctor

        #region Methods

        /// <summary>
        /// Service responsible for update game results of users
        /// </summary>
        /// <param name="results">List of game results</param>
        /// <returns>If you have updated return 1, if 0 is failed</returns>
        public bool UpdateResults(List<GameResultDTO> results)
        {
            try
            {
                foreach (GameResultDTO result in results)
                {
                    GameResult gameResult = GameResultRepository.GetResult(result.GameId, result.PlayerId);

                    if (gameResult != null)
                    {
                        gameResult.Win += result.Win;
                        gameResult.Timestamp = result.Timestamp > gameResult.Timestamp ? result.Timestamp : gameResult.Timestamp;
                        GameResultRepository.Update(gameResult);
                        continue;
                    }

                    GameResultRepository.Add(new GameResult
                    {
                        GameId = result.GameId,
                        PlayerId = result.PlayerId,
                        Win = result.Win,
                        Timestamp = result.Timestamp
                    });
                }

                return true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Service responsible for get List of games
        /// </summary>
        /// <returns>List of games</returns>
        public List<long> GetGamesList()
        {
            return GameResultRepository.GetGamesList();
        }

        /// <summary>
        /// Service responsible for get results of a specific game
        /// </summary>
        /// <param name="gameId">Game identifier</param>
        /// <returns>List of game results</returns>
        public List<LeaderboardDTO> GetGamesResultList(int gameId)
        {
            List<LeaderboardDTO> leaderboardList = new List<LeaderboardDTO>();
            GameResultRepository.GetGameResultList(gameId).ForEach(gr => leaderboardList.Add(new LeaderboardDTO(gr)));

            return leaderboardList;
        }

        /// <summary>
        /// Service responsible for get the results of users based on the number of games performed
        /// </summary>
        /// <returns>List of most played users</returns>
        public List<ResultsGamesPlayedDTO> GetResultsByGamePlayed()
        {
            return GameResultRepository.GetResultsByGamePlayed();
        }

        #endregion Methods
    }
}

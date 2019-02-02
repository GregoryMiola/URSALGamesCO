using Domain.DTOs;
using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;

namespace Service.Services
{
    public class GameResultService : IGameResultService
    {
        private IGameResultRepository GameResultRepository;

        public GameResultService(IGameResultRepository gameResultRepository) => this.GameResultRepository = gameResultRepository;

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

        public List<long> GetGamesList()
        {
            return GameResultRepository.GetGamesList();
        }

        public List<LeaderboardDTO> GetGamesResultList(int gameId)
        {
            List<LeaderboardDTO> leaderboardList = new List<LeaderboardDTO>();
            GameResultRepository.GetGameResultList(gameId).ForEach(gr => leaderboardList.Add(new LeaderboardDTO(gr)));

            return leaderboardList;
        }

        public List<ResultsGamesPlayedDTO> GetResultsByGamePlayed()
        {
            return GameResultRepository.GetResultsByGamePlayed();
        }
    }
}

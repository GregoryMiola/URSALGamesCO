using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;

namespace Service.Services
{
    public class GameService : IGameService
    {
        private IGameRepository GameRepository;

        public GameService(IGameRepository gameRepository) => this.GameRepository = gameRepository;

        public IEnumerable<Game> GetAll()
        {
            return GameRepository.GetAll();
        }

        public Game GetById(long gameId)
        {
            return GameRepository.GetById(gameId);
        }

        public long Add(Game game)
        {
            return GameRepository.Add(game);
        }

        public long Update(Game game)
        {
            return GameRepository.Update(game);
        }

        public bool Remove(long gameId)
        {
            return GameRepository.Remove(gameId);
        }
    }
}

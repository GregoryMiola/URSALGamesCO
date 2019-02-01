using Domain.Models;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IGameService
    {
        IEnumerable<Game> GetAll();
        Game GetById(long gameId);
        long Add(Game game);
        long Update(Game game);
        bool Remove(long gameId);
    }
}

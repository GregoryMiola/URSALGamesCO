using Data.SQLite.Context;
using Domain.Interfaces;
using Domain.Models;

namespace Data.SQLite.Repositories
{
    public class GameRepository : BaseRepository<Game>, IGameRepository
    {
        public GameRepository(URSALGamesCOContext context) : base(context)
        {
        }
    }
}

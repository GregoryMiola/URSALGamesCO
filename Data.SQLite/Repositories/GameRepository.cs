using Data.SQLite.Context;
using Domain.Interfaces;
using Domain.Models;

namespace Data.SQLite.Repositories
{
    /// <summary>
    /// Repository of games entity
    /// </summary>
    public class GameRepository : BaseRepository<Game>, IGameRepository
    {
        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="context">Context of database application</param>
        public GameRepository(URSALGamesCOContext context) : base(context)
        {
        }

        #endregion Ctor
    }
}

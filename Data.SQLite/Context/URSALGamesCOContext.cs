using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.SQLite.Context
{
    /// <summary>
    /// Context of solution
    /// </summary>
    public class URSALGamesCOContext : DbContext
    {
        #region Property

        /// <summary>
        /// Property for Game dbSet
        /// </summary>
        public DbSet<Game> Game { get; set; }

        /// <summary>
        /// Property for Game Results dbSet
        /// </summary>
        public DbSet<GameResult> GameResults { get; set; }

        #endregion Property

        #region Methods

        /// <summary>
        /// Override this method to configure the database (and other options) to be used for this context.
        /// </summary>
        /// <param name="optionsBuilder"> builder used to create or modify options for this context.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WebApplication.db");
        }

        #endregion Methods
    }
}

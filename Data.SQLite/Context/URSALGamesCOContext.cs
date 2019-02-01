using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.SQLite.Context
{
    public class URSALGamesCOContext : DbContext
    {
        public DbSet<Game> Game { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WebApplication.db");
        }
    }
}

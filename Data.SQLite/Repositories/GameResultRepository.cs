﻿using Data.SQLite.Context;
using Domain.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Data.SQLite.Repositories
{
    public class GameResultRepository : BaseRepository<GameResult>, IGameResultRepository
    {
        private URSALGamesCOContext Context;

        public GameResultRepository(URSALGamesCOContext context) : base(context)
        {
            Context = context;
        }

        public GameResult GetResult(long gameId, long playerId)
        {
            return Context.GameResults.Where(gr => gr.GameId == gameId && gr.PlayerId == playerId).FirstOrDefault();
        }

        public List<long> GetGamesList()
        {
            return Context.GameResults.Select(gr => gr.GameId).Distinct().ToList();
        }

        public List<GameResult> GetGameResultList(int gameId)
        {
            return Context.GameResults.Where(gr => gr.GameId == gameId).Take(100).OrderByDescending(gr => gr.Win).ToList();
        }
    }
}
using Domain.Models;
using System;

namespace Domain.DTOs
{
    /// <summary>
    /// Data Transfer Object of Leaderboard
    /// </summary>
    public class LeaderboardDTO
    {
        #region Property

        /// <summary>
        /// Property of Player identifier
        /// </summary>
        public long PlayerId { get; set; }
        /// <summary>
        /// Property of balance of player 
        /// </summary>
        public long Balance { get; set; }
        /// <summary>
        /// Property of last register updated
        /// </summary>
        public DateTime LastUpdateDate { get; set; }

        #endregion Property

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="gameResult">Game result of player</param>
        public LeaderboardDTO(GameResult gameResult)
        {
            PlayerId = gameResult.PlayerId;
            Balance = gameResult.Win;
            LastUpdateDate = gameResult.Timestamp;
        }

        #endregion Ctor
    }
}

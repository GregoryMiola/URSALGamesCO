using System;

namespace Domain.DTOs
{
    /// <summary>
    /// Data Transfer Object of games result
    /// </summary>
    public class GameResultDTO
    {
        #region Property

        /// <summary>
        /// Property of game identifier
        /// </summary>
        public long GameId { get; set; }
        /// <summary>
        /// Property of player identifier
        /// </summary>
        public long PlayerId { get; set; }
        /// <summary>
        /// Property of balance player
        /// </summary>
        public long Win { get; set; }
        /// <summary>
        /// Property of register datetime
        /// </summary>
        public DateTime Timestamp { get; set; }

        #endregion Property
    }
}

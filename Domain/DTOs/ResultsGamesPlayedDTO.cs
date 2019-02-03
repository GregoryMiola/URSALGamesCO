namespace Domain.DTOs
{
    /// <summary>
    /// Data Transfer Object of Result games played
    /// </summary>
    public class ResultsGamesPlayedDTO
    {
        #region Property

        /// <summary>
        /// Property of Player identifier
        /// </summary>
        public long PlayerId { get; set; }
        /// <summary>
        /// Property of balance of games played
        /// </summary>
        public long GamesPlayed { get; set; }

        #endregion Property
    }
}

using System;
using Domain.Models;

namespace Domain.DTOs
{
    public class LeaderboardDTO
    {
        public long PlayerId { get; set; }
        public long Balance { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public LeaderboardDTO(GameResult gameResult)
        {
            PlayerId = gameResult.PlayerId;
            Balance = gameResult.Win;
            LastUpdateDate = gameResult.Timestamp;
        }
    }
}

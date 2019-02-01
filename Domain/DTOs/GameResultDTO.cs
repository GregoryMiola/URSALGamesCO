using System;

namespace Domain.DTOs
{
    public class GameResultDTO
    {
        public long GameId { get; set; }
        public long PlayerId { get; set; }
        public long Win { get; set; }
        public DateTime Timestamp { get; set; }
    }
}

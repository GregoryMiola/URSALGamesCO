using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class GameResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long GameId { get; set; }
        public long PlayerId { get; set; }
        public long Win { get; set; }
        public DateTime Timestamp { get; set; }
    }
}

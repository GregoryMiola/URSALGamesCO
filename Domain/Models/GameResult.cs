using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    /// <summary>
    /// Entity of games result
    /// </summary>
    public class GameResult
    {
        #region Property

        /// <summary>
        /// Record Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        /// <summary>
        /// Game identifier
        /// </summary>
        public long GameId { get; set; }
        /// <summary>
        /// Player identifier
        /// </summary>
        public long PlayerId { get; set; }
        /// <summary>
        /// Balance of player
        /// </summary>
        public long Win { get; set; }
        /// <summary>
        /// Record date
        /// </summary>
        public DateTime Timestamp { get; set; }

        #endregion Property
    }
}

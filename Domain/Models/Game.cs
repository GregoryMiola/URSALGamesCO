using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    /// <summary>
    /// Entity of game
    /// </summary>
    public class Game
    {
        #region Property

        /// <summary>
        /// Game identifier
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long GameId { get; set; }
        /// <summary>
        /// Title of game
        /// </summary>
        public string Title { get; set; }

        #endregion Property
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStatsServices.Models
{
    /// <summary>
    /// Player special event information
    /// </summary>
    public class PlayerSpecialEvent
    {
        /// <summary>
        /// Gets or sets the player special event type (incapacitated)
        /// </summary>
        public StatsType EventType { get; set; }
        /// <summary>
        /// Gets or sets target player identifier (SteamId when target player is human controlled) - CAN BE EMPTY
        /// </summary>
        public string TargetPlayerId { get; set; }
        /// <summary>
        /// Gets or sets value indicating did the target player die
        /// </summary>
        public bool TargetPlayerKilled { get; set; }
        /// <summary>
        /// Gets or sets value indicating if the player is a NPC
        /// </summary>
        public bool IsNonPlayerCharacter { get; set; }
    }
}

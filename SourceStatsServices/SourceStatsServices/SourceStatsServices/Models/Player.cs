using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStatsServices.Models
{
    /// <summary>
    /// Player information
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Gets or sets player Steam identifier
        /// </summary>
        public string SteamId { get; set; }
        /// <summary>
        /// Gets or sets player name - Always applies
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets player type (Sniper, Grenadier, Smoker, etc.)
        /// </summary>
        public StatsType PlayerType { get; set; }
        /// <summary>
        /// Gets or set player weapon information
        /// </summary>
        public Weapon[] Weapons { get; set; }
        /// <summary>
        /// Gets or sets player special event information
        /// </summary>
        public PlayerSpecialEvent[] SpecialEvents { get; set; }
        /// <summary>
        /// Gets or sets player playtime in seconds
        /// </summary>
        public int PlayTimeSeconds { get; set; }
    }
}

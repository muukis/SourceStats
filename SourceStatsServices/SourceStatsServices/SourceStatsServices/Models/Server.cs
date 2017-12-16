using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStatsServices.Models
{
    /// <summary>
    /// Server information
    /// </summary>
    public class Server
    {
        /// <summary>
        /// Gets or sets server type (Left4Dead, Left4Dead2, Counter-Strike: Global Offensive, etc.)
        /// </summary>
        public StatsType ServerType { get; set; }
        /// <summary>
        /// Gets or sets the game type (team death match, capture the flag, versus, co-op, etc.)
        /// </summary>
        public StatsType GameType { get; set; }
    }
}

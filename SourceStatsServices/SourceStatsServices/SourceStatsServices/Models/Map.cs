using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStatsServices.Models
{
    /// <summary>
    /// Map information
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Gets or sets map type
        /// </summary>
        public StatsType MapType { get; set; }
        /// <summary>
        /// Gets or sets map playtime in seconds
        /// </summary>
        public int PlayTimeSeconds { get; set; }
    }
}

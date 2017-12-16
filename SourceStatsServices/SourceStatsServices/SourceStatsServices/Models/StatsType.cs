using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStatsServices.Models
{
    /// <summary>
    /// Statistics type information
    /// </summary>
    public class StatsType
    {
        /// <summary>
        /// Gets or sets the stats type identifier
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Gets or sets the stats type name - Only applies if new stats type identifier
        /// </summary>
        public string Name { get; set; }
    }
}

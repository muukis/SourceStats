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
        /// Gets or sets map identifier
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Gets or sets map name - Only applies when saving a new map identifier
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the map type identifier (tdm etc.)
        /// </summary>
        public string TypeId { get; set; }
        /// <summary>
        /// Gets or sets the map type name (team death match etc.) - Only applies when saving a new map type identifier
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// Gets or sets map playtime in seconds
        /// </summary>
        public int PlayTimeSeconds { get; set; }
    }
}

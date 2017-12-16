using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStatsServices.Models
{
    /// <summary>
    /// Weapon information
    /// </summary>
    public class Weapon
    {
        /// <summary>
        /// Gets or sets weapon type
        /// </summary>
        public StatsType WeaponType { get; set; }
        /// <summary>
        /// Gets or sets weapon total shots fired (including missed shots)
        /// </summary>
        public int TotalShotsFired { get; set; }
        /// <summary>
        /// Gets or sets weapon actions
        /// </summary>
        public WeaponAction[] Actions { get; set; }
    }
}

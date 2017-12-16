using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStatsServices.Models
{
    /// <summary>
    /// Weapon action information
    /// </summary>
    public class WeaponAction
    {
        /// <summary>
        /// Gets or sets target player identifier (SteamId when target player is human controlled)
        /// </summary>
        public string TargetPlayerId { get; set; }
        /// <summary>
        /// Gets or sets shots fired on targetted player
        /// </summary>
        public int ShotsFired { get; set; }
        /// <summary>
        /// Gets or sets target body part identifier
        /// </summary>
        public string TargetBodyPartId { get; set; }
        /// <summary>
        /// Gets or sets the name of the target body part (head, chest, left arm, etc.) - Only applies when saving a new target body part
        /// </summary>
        public string TargetBodyPartName { get; set; }
        /// <summary>
        /// Gets or sets the amount of damage
        /// </summary>
        public decimal DamageAmount { get; set; }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStatsServices.Models
{
    public class WeaponAction
    {
        public string TargetPlayerId { get; set; }
        public int ShotsFired { get; set; }
        public string TargetBodyPartId { get; set; }
        public string TargetBodyPartName { get; set; }
        public decimal DamageAmount { get; set; }
        public bool TargetPlayerKilled { get; set; }
        public bool IsNonPlayerCharacter { get; set; }
    }
}

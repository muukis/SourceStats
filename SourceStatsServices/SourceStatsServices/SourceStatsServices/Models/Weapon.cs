using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStatsServices.Models
{
    public class Weapon
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int TotalShotsFired { get; set; }
        public WeaponAction[] Actions { get; set; }
    }
}

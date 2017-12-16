using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStatsServices.Models
{
    public class Player
    {
        public string SteamId { get; set; }
        public string Name { get; set; }
        public Weapon[] Weapons { get; set; }
        public int PlayTimeSeconds { get; set; }
    }
}

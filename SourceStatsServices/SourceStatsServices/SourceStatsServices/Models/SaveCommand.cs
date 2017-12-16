using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStatsServices.Models
{
    public class SaveCommand : CommandBase
    {
        public Map Map { get; set; }
        public Player[] Players { get; set; }
    }
}

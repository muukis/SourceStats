using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStatsServices.Models
{
    /// <summary>
    /// Save player statistics command
    /// </summary>
    public class SaveCommand : CommandBase
    {
        /// <summary>
        /// Gets or sets the saved map information
        /// </summary>
        public Map Map { get; set; }
        /// <summary>
        /// Gets or sets the saved player information
        /// </summary>
        public Player[] Players { get; set; }

        public override string ToString()
        {
            return $"Server identity token: {(ServerIdentityToken ?? "NULL")} " +
                $"(MapId: {(Map?.Id ?? "NULL")} / " +
                $"Players.Count: {(Players?.Length.ToString() ?? "NULL")})";
        }
    }
}

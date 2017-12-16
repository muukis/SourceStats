using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStatsServices.Models
{
    /// <summary>
    /// Command base for all different command types
    /// </summary>
    public abstract class CommandBase
    {
        /// <summary>
        /// Gets or sets server identity token (must match the available tokens to save)
        /// </summary>
        public string ServerIdentityToken { get; set; }
    }
}

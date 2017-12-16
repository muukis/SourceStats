using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SourceStatsServices.Models;

namespace SourceStatsServices.Controllers
{
    [Route("api/[controller]")]
    public class SourceStatsController : Controller
    {
        [HttpPost]
        public void Post([FromBody]SaveCommand saveCommand)
        {
        }
    }
}

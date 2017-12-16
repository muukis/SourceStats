using log4net;
using Microsoft.AspNetCore.Mvc;
using SourceStatsServices.Models;
using System;
using System.Net;

namespace SourceStatsServices.Controllers
{
    [Route("api/[controller]")]
    public class SourceStatsController : Controller
    {
        private static readonly ILog _logger;

        static SourceStatsController()
        {
            _logger = LogManager.GetLogger(typeof(SourceStatsController));
        }

        [HttpPost]
        public void Post([FromBody]SaveCommand saveCommand)
        {
            _logger.Info($"Save command received: {saveCommand}");

            try
            {
                // Todo: Validate server identity token
                // Todo: Save stats using entity framework
            }
            catch (Exception e)
            {
                _logger.Fatal("Save command failed.", e);
                throw new WebException("Save command failed.");
            }
        }
    }
}

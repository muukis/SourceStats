using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;

namespace SourceStatsServices.Support
{
    public static class Logger
    {
        static Logger()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
        }

        public static ILog GetLogger<T>(this T obj) where T : class
        {
            return LogManager.GetLogger(typeof(T));
        }

        public static ILog GetLogger(Type type)
        {
            return LogManager.GetLogger(type);
        }
    }
}

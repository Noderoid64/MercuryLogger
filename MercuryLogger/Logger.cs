using System.Collections.Generic;
namespace MercuryLogger
{
    public abstract class Logger
    {
        public abstract void Log(string value);
        List<Logger> loggers;
        

        public Logger()
        {
            loggers = new List<Logger>();
        }
        public void AddLogger(Logger logger)
        {
            loggers.Add(logger);
        }

        protected void LogAll(string message)
        {
            foreach (var item in loggers)
            {
                item.Log(message);
            }
        }
    }
}

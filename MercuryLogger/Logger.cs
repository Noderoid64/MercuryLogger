using System.Collections.Generic;
using System;
namespace MercuryLogger
{
    public abstract class Logger
    {
        public abstract void Log(string value);
        List<Logger> loggers;
        public IExceptionHandler handler { get; set; }
        public Logger()
        {
            loggers = new List<Logger>();
        }
        public void AddLogger(Logger logger)
        {
            loggers.Add(logger);
        }
        public void ExceptionHandle(Exception e)
        {
            try
            {
                handler.Hand(e);
            }
            catch (Exception ee)
            {
                HandleAll(ee);
            }
            finally
            {
                HandleAll(e);
            }
        }
        protected void LogAll(string message)
        {
            foreach (var item in loggers)
            {
                item.Log(message);
            }
        }
        protected void HandleAll(Exception e)
        {
            foreach (var item in loggers)
            {
                item.ExceptionHandle(e);
            }
        }
    }
}

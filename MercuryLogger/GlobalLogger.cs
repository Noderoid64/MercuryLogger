using System;

namespace MercuryLogger
{
    public class GlobalLogger : Logger
    {
        #region Singleton
        static object SyncObject = new object();
        static GlobalLogger instance;
        private GlobalLogger() { }

        public static GlobalLogger GetInstance()
        {
            lock (SyncObject)
            {
                if (instance == null)
                    instance = new GlobalLogger();
            }
            return instance;
        }
        #endregion
        public override void Log(string value)
        {
            lock (SyncObject)
            {
                try
                {
                    LogAll(value);
                }
                catch (Exception e)
                {
                    HandleAll(e);
                }

            }
        }
    }
}
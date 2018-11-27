using System;
using System.Reflection;
using Xunit;
using MercuryLogger;
using MercuryLogger.Loggers;
using MercuryLogger.Extentions;

namespace MercuryLogger.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            GlobalLogger logger = GlobalLogger.GetInstance();
            Logger log = new FileLogger("./");
            TimeExtention TimeExtention = new TimeExtention()
            {
                ShowYear = false,
                ShowDay = false,
                ShowMonth = false,
                ShowHour = true,
                ShowMinute = true,
                ShowSecond = true,
                ShowMillisecond = true
            };
            TimeExtention.AddLogger(log);
            logger.AddLogger(TimeExtention);
            logger.Log("Hello mutherfucker");


        }
    }
}

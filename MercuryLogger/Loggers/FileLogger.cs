using System;
using System.Text;
using System.IO;

namespace MercuryLogger.Loggers
{
    public class FileLogger : Logger
    {
        StreamWriter sw;
        public FileLogger(string path)
        {

        }
        public FileLogger(string path, string name)
        {

        }
        public FileLogger(string path, string name, Encoding encoding, bool Append)
        {
            sw = new StreamWriter(path + name, Append, encoding);
        }

        public override void Log(string value)
        {
            throw new NotImplementedException();
        }
    }
}
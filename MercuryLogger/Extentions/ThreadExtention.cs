using System;
using System.Text;
using System.Threading;

namespace MercuryLogger.Extentions
{
    public class ThreadExtention : Logger
    {
        bool IsAlive { get; set; }
        bool IsBackground { get; set; }
        bool IsThreadPoolThread { get; set; }
        bool ManagedThreadId { get; set; }
        bool Name { get; set; }
        bool Priority { get; set; }
        bool ThreadState { get; set; }
        bool ExecutionContext { get; set; }

        public override void Log(string value)
        {
            Thread t = Thread.CurrentThread;
            StringBuilder builder = new StringBuilder(400);
            builder.Append("ThreadExtention:\n");
            if(IsAlive)
            builder.Append("Is Alive:           " + t.IsAlive + "\n");
                        if(IsBackground)
            builder.Append("Is Background:      " + t.IsBackground + "\n");
                        if(IsThreadPoolThread)
            builder.Append("Is ThreadPoolThread:" + t.IsThreadPoolThread + "\n");
                        if(ManagedThreadId)
            builder.Append("Is ManagedThreadId: " + t.ManagedThreadId + "\n");
                        if(Name)
            builder.Append("Name:               " + t.Name + "\n");
                        if(Priority)
            builder.Append("Priority:           " + t.Priority + "\n");
                        if(ThreadState)
            builder.Append("ThreadState:        " + t.ThreadState + "\n");
                        if(ExecutionContext)
            builder.Append("ExecutionContext:   " + t.ExecutionContext + "\n");

            LogAll(builder.ToString() + value);
        }
    }
}
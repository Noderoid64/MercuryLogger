using System;

namespace MercuryLogger
{
    public interface IExceptionHandler
    {
        void Hand();
        IExceptionHandler Component { get; set; }
    }
}
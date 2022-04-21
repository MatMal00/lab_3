using System;
using System.IO;

namespace Lab_3.Logger
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;
        protected DateTime time = DateTime.Now;

        public virtual void Log(params string[] messages)
        {
        }

        public abstract void Dispose();

    }
}

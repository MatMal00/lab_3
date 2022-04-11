using System;
using System.IO;

namespace Lab_3.Logger
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
        }

        public abstract void Dispose();

    }
}

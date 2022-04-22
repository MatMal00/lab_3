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
            string messageToSend = time.ToString("yyyy-MM-ddTHH:mm:sszzz") + ": ";
            foreach (var message in messages) messageToSend += message + " ";

            writer.WriteLine(messageToSend);
            writer.Flush();
        }

        public abstract void Dispose();

    }
}

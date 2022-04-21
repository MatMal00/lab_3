using System;
using System.IO;
using System.Text;

namespace Lab_3.Logger
{
    class FileLogger : WriterLogger
    {
        private bool disposed;
        protected FileStream stream = null;
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }

        public override void Log(params string[] messages)
        {
            using (FileStream stream = new FileStream(path, FileMode.Append))
            {
                using (TextWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {

                    foreach (var message in messages) writer.WriteLine(message);
                    writer.Flush();
                }

            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (stream != null) this.stream.Dispose();
                }

                this.disposed = true;
            }
        }

        public override void Dispose()
        {
            this.Dispose(disposing: true);
        }

        ~FileLogger()
        {
            Dispose(disposing: false);
        }
    }
}

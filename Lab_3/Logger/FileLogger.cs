using System.IO;
using System.Text;

namespace Lab_3.Logger
{
    class FileLogger : WriterLogger
    {
        private bool disposed;
        protected FileStream stream = null;

        public FileLogger(string path)
        {
            stream = new FileStream(path, FileMode.Append);
        }

        public override void Log(params string[] messages)
        {
            try
            {
                using (writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    foreach (var message in messages) writer.WriteLine(message);
                }
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
                writer.Dispose();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    this.stream.Dispose();

                this.disposed = true;
            }
        }

        public override void Dispose()
        {
            this.Dispose(disposing: true);
        }
    }
}

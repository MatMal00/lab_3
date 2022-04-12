using System;
using System.Text;

namespace Lab_3.Logger
{
    class SocketLogger : ILogger
    {
        private ClientSocket clientSocket;
        private bool disposedValue;

        public SocketLogger(string host, int port)
        {
            this.clientSocket = new ClientSocket(host, port);
        }

        public void Log(params string[] messages)
        {
            try
            {
                foreach (var message in messages) clientSocket.Send(Encoding.UTF8.GetBytes(message));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                clientSocket.Close();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                    clientSocket.Dispose();

                disposedValue = true;
            }
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        ~SocketLogger()
        {
            Dispose(disposing: false);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Logger
{
    class SocketLogger: ILogger
    {
        private ClientSocket clientSocket;
        private bool disposedValue;

        public SocketLogger(string host, int port)
        {

        }

        public void Log(params string[] messages)
        {

        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    clientSocket.Dispose();
                }

                // TODO: Zwolnić niezarządzane zasoby (niezarządzane obiekty) i przesłonić finalizator
                // TODO: Ustawić wartość null dla dużych pól

                disposedValue = true;
            }
        }


        public void Dispose()
        {
            // Nie zmieniaj tego kodu. Umieść kod czyszczący w metodzie „Dispose(bool disposing)”.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        ~SocketLogger()
        {
            Dispose(disposing: false);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Logger
{
    class ConsoleLogger : WriterLogger
    {
        public override void Log(params string[] messages)
        {

            writer = Console.Out;
            string messageToSend = time.ToString("yyyy-MM-ddTHH:mm:sszzz") + ": ";
            foreach (var message in messages) messageToSend += message + " ";

            writer.WriteLine(messageToSend);
        }

        public override void Dispose()
        {
        }
    }
}

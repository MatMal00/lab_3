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
            foreach (var message in messages) writer.WriteLine(message);
        }

        public override void Dispose()
        {
        }
    }
}

using Lab_3.Logger;
using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SocketLogger logger = new SocketLogger("google.com", 80);

            logger.Log("eee");
        }
    }
}

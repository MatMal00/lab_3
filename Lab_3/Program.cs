using Lab_3.Logger;
using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
           FileLogger logger = new FileLogger("text.txt");

            logger.Log("eee");

            
        }
    }
}

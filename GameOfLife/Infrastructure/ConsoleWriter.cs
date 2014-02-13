using System;

namespace GameOfLife.Infrastructure
{
    class ConsoleWriter : IWriter
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }
    }
}

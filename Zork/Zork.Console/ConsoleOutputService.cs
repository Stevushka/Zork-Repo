using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    public class ConsoleOutputService : IOutputService
    {
        public void Write(object value)
        {
            Console.Write(value);
        }

        public void WriteLine(object value)
        {
            Console.WriteLine(value);
        }
    }
}

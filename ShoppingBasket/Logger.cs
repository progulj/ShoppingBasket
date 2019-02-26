using System;

namespace ShoppingBasktComponent
{
    class Logger : ILogger
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }

    }
}

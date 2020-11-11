using System;

namespace ch8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public abstract class CloneableType
        {
            public abstract object Clone();
        }

        
    }
}

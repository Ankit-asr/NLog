using System;

namespace NLogProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NLog");
            Addition obj = new Addition();
            obj.Sum(10, 20);
        }
    }
}

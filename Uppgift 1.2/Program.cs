using System;
namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Your Pc has crashed and requires a restart");
            Console.WriteLine("We are just collecting error info,");
            Console.WriteLine("and then we'll restart for you.");
        }
    }
}

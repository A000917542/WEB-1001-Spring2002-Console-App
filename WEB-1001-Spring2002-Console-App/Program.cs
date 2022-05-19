using System;

namespace WEB_1001_Spring2002_Console_App
{
    internal class Program
    {
        public static readonly string x = "hello";

        static void Main(string[] args)
        {
            int r = 5;
            int g = 6;
            int b = 7;

            int c = r + g;

            Console.WriteLine(c);

            Hello();

            Goodbye();
        }

        static void Hello()
        { Console.WriteLine("Hello"); }

        static void Goodbye()
        {
            Console.WriteLine(x);
            Console.WriteLine("Goodbye!");
        }
    }
}

using System;

namespace Ozel
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor onrenk = ConsoleColor.White;
            ConsoleColor arkarenk = ConsoleColor.Red;
            Console.ForegroundColor = onrenk;
            Console.BackgroundColor = arkarenk;


            int x = 100;
            decimal y = 100.25m;
            bool EH = true;
            string ad = "nida";

            x *= 2;

            Console.WriteLine("Int : " + x);
            Console.WriteLine("Decimal :" + y);
            Console.WriteLine("Bool : " + EH);
            Console.WriteLine("String : " + ad);

        }
    }
}

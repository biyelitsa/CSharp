using System;

namespace objectTip
{
    class Program
    {
        static void Main(string[] args)
        {
            object onrenk = ConsoleColor.White;
            ConsoleColor arkarenk = ConsoleColor.Red;
            Console.ForegroundColor = (ConsoleColor) onrenk;
            Console.BackgroundColor = arkarenk;


            object x = 100;
            var y = 100.25m;
            object EH = true;
            string ad = "nida";

            x = (int) x * 2;

            Console.WriteLine("Int : " + x);
            Console.WriteLine("Decimal :" + y);
            Console.WriteLine("Bool : " + EH);
            Console.WriteLine("String : " + ad);
        }
    }
}

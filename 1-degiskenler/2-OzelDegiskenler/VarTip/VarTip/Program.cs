using System;

namespace VarTip
{
    class Program
    {
        static void Main(string[] args)
        {
            var onrenk = ConsoleColor.White;
            ConsoleColor arkarenk = ConsoleColor.Red;
            Console.ForegroundColor = onrenk;
            Console.BackgroundColor = arkarenk;


            var x = 100;
            var y = 100.25m;
            var EH = true;
            string ad = "nida";

            x *= 2;

            Console.WriteLine("Int : " + x);
            Console.WriteLine("Decimal :" + y);
            Console.WriteLine("Bool : " + EH);
            Console.WriteLine("String : " + ad);

        }
    }
}

using System;
using System.Linq;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 25, 7, 66 };
            Console.WriteLine(sayilar.Length);
            Console.WriteLine(sayilar.Count());
            Console.WriteLine(sayilar[2]);
            Console.WriteLine(sayilar.Max());
            Console.WriteLine(sayilar.Min());
            Console.WriteLine(sayilar.Sum());
            Console.WriteLine(sayilar.Average());

            string[] aylar = { "ocak", "şubat", "mart", "nisan", "mart" };
            Console.WriteLine(aylar.Length);
            Console.WriteLine(aylar.Count());
            Console.WriteLine(aylar[3]);
            
            
        }
    }
}

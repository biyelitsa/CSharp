using System;

namespace StringMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "nida";
            Console.WriteLine(ad.ToLower());
            Console.WriteLine(ad.ToUpper());
            string str = "Gurultu";
            Console.WriteLine(str.Contains("ul"));
            Console.WriteLine(str.GetType());
            Console.WriteLine(str.IndexOf("u"));
            Console.WriteLine(str.EndsWith("n"));
            Console.WriteLine(str.StartsWith("G"));
            Console.WriteLine(str.Replace('u', 'ü'));
            Console.WriteLine(str.Substring(4));
            string ad1 = "**nida***";
            Console.WriteLine(ad1.TrimEnd());
            Console.WriteLine(str.Length);
            Console.WriteLine(str.PadRight(50));
            Console.WriteLine(ad1.Trim('*'));
            
        }
    }
}

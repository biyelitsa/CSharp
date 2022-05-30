

using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main()
        {
            string isKod;
            int s1 = 0; 
            int s2 = 0;


                try
                {
                    Console.WriteLine("Birinci sayı?");   
                    s1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("İkinci sayı?");
                    s2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("İşlem Kodu + - * /");
                    isKod = Console.ReadLine();
                    if (isKod == "+")
                    {
                        int top = s1 + s2;
                        Console.WriteLine("Sonuç: " + top);
                    } else if (isKod == "-")
                    {
                        int cık = s1 - s2;
                        Console.WriteLine("Sonuç: " + cık);
                    } else if (isKod == "*")
                    {
                        int carp = s1 * s2;
                        Console.WriteLine("Sonuç: " + carp);
                    } else if (isKod == "/")
                    {
                        float bol = (float)s1 / (float)s2;
                        Console.WriteLine("Sonuç: " + bol);
                    } else if (isKod == "%")
                    {
                        int mod = s1 % s2;
                        Console.WriteLine("Sonuç: " + mod);
                    }
                    else
                    {
                        Console.WriteLine("Lütfen operatör giriniz.");
                    }
                    Main();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Main();
                }
           

        }
    }
}

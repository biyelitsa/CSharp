

using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main()
        {
            int s1 = 0; 
            int s2 = 0;

            Console.WriteLine("Birinci sayı?");
                try
                {
                    s1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sayısal değer giriniz.");
                    Main();
                }
            
            Console.WriteLine("İkinci sayı?");
                try
                {
                   s2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sayısal değer giriniz.");
                    Main();
                }
            


            int top = s1 + s2;
            int cık = s1 - s2;
            int carp = s1 * s2;
            
            Console.WriteLine("Sonuç: " + top);
            Console.WriteLine("Sonuç: " + cık);   
            Console.WriteLine("Sonuç: " + carp);
            

        }
    }
}

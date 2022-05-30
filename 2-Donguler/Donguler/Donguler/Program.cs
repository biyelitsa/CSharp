using System;

namespace Donguler
{
    class Program
    {
        static int[] sayilar = { 10, 15, 72, 37, 48 };
        static int sayac = 0;
        static int toplam = 0;
        static void Main(string[] args)
        {
            BaslikYaz("For Döngüsü");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sayilar[i]);
                toplam += sayilar[i];
            }
            ToplamYaz(toplam);

            BaslikYaz("Do-While Döngüsü");
            toplam = 0;
            do
            {
                Console.WriteLine(sayilar[sayac]);
                toplam += sayilar[sayac];
                sayac++;
            } while (sayac < sayilar.Length);
            ToplamYaz(toplam);


            BaslikYaz("While Döngüsü");
            sayac = 0;
            toplam = 0;
            while (sayac < sayilar.Length)
            {
                Console.WriteLine(sayilar[sayac]);
                toplam += sayilar[sayac];
                sayac++;
            }
            ToplamYaz(toplam);


            BaslikYaz("Foreach Döngüsü");
            toplam = 0;
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
                toplam += item;
              
            }
            ToplamYaz(toplam);

        }

        private static void BaslikYaz(string bas)
        {
            Console.WriteLine("*************");
            Console.WriteLine(bas);
            Console.WriteLine("*************");
        }

        private static void ToplamYaz(int top)
        {
            Console.WriteLine("_____________");
            Console.WriteLine("Toplam: " + top);
            Console.WriteLine("_____________");
        }

    }
}

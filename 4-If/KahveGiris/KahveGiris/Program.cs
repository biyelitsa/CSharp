using System;

namespace KahveGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Adınızı Giriniz.");
            string ad = Console.ReadLine();
            Console.WriteLine("Merhaba " + ad + " Yaşınızı Giriniz.");
            int yas = Convert.ToInt32(Console.ReadLine());

            if (yas >= 18)
            {
                Console.WriteLine($"Kahveye Hoşgeldin. {ad} ");
                //Console.WriteLine("Kahveye Hoşgeldin " + ad);
            } else
            {
                int bekle = 18- yas;
                //Console.WriteLine("Kahveye girmeye uygun değilsizniz. " + bekle + " yıl daha beklemeniz gerekmektedir.");
                Console.WriteLine($"Kahveye Girmeye Uygun Değilsiniz. {bekle} yıl daha beklemeniz gerekmektedir." );
                //Console.WriteLine("Kahveye Girmeye Uygun Değilsiniz. {0} yıl daha beklemeniz gerekmektedir.", bekle);
                
            }

            Console.ReadLine();
            Main(null);
        }
    }
}

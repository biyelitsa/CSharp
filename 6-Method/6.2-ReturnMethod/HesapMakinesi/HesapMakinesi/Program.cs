using System;

namespace HesapMakinesi
{
    class Program
    {
        static decimal s1, s2;
        static void Main(string[] args)
        {
            decimal s1 = Cevir("Birinci sayıyı girin.");
            decimal s2 = Cevir("İkinci sayıyı girin.");
            string isKod = Islem();
            decimal sonuc = Hesapla(isKod, s1 , s2);
            Yazdir(sonuc);
        }

        private static void Yazdir(decimal sonuc)
        {
            if (sonuc == 0 && s2 == 0)
            {
                Console.WriteLine("error");
            } else
            {
                Console.WriteLine("sonuc: "+ sonuc);
            }
            Main(null);
        }

        private static decimal Hesapla(string isKod, decimal s1, decimal s2)
        {
            decimal sonuc = 0;
           if (isKod == "+")
            {
                sonuc = Topla(s1,s2);
            } else if (isKod == "*")
            {
                sonuc = Carp(s1, s2);
            } else if (isKod == "-")
            {
                sonuc = Cıkar(s1, s2);
            } else if (isKod == "/")
            {
                sonuc = Bol(s1, s2);
            }
            return sonuc;
        }

        private static decimal Bol(decimal s1, decimal s2)
        {
                return s1 / s2;
        }

        private static decimal Cıkar(decimal s1, decimal s2)
        {
            return s1 - s2;
        }

        private static decimal Carp(decimal s1, decimal s2)
        {
            return s1 * s2;
        }

        private static decimal Topla(decimal s1, decimal s2)
        {
            return s1 + s2;
        }

        private static string Islem()
        {
            Console.WriteLine("İşlem kodunu giriniz. (+ , - , / , *)");
            string isKod = Console.ReadLine();
            if (isKod == "+" || isKod == "-" || isKod == "/" || isKod == "*")
            {
                return isKod;

            } else
            {
                Console.WriteLine("Geçersiz operatör girişi yapıldı. Tekrar deneyiniz. (+ , - , * , /)");
            }
            return Islem();
        }

        private static decimal Cevir(string txt)
        {
            try
            {
                Console.WriteLine(txt);
                return Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Sayısal değer giriniz.");
                return Cevir(txt);
            }
            
        }
    }
}

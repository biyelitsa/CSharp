using System;

namespace KacParamVarIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal tl = ConvertDecimal("Kaç tl var?");
            decimal dolar = ConvertDecimal("Kaç dolar var?");
            decimal euro = ConvertDecimal("Kaç euro var?");
            decimal toplam = RateCalculate(dolar, "Dolar") + RateCalculate(euro, "Euro") + tl;
            Yazdir(toplam);
        }

        private static void Yazdir(decimal toplam)
        {
            Console.WriteLine("Toplam Para: " + toplam);
        }

        private static decimal RateCalculate(decimal forex, string tur)
        {
            try
            {
                Console.WriteLine("{0} Kurunu Giriniz.", tur);
                decimal kur = Convert.ToDecimal(Console.ReadLine());
                return kur * forex;
            }
            catch (Exception)
            {
                Console.WriteLine("SAYISAL DEĞER GİRİNİZ!");
                return RateCalculate(forex, tur); 
            }
        }

        static decimal ConvertDecimal(string txt)
        {
            try
            {
                Console.WriteLine(txt);
                return Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception )
            {
                Console.WriteLine("Sayısal değer girin.");
                return ConvertDecimal(txt); ;
            }
        }



    }
}

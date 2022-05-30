using System;

namespace KacParamVarMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Kaç TL var?");
                int tl = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kaç Dolar var?");
                int dolar = Convert.ToInt32(Console.ReadLine());
                DolarHesapla(dolar,tl);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main(null);
            }

        }

        private static void DolarHesapla(int dolar,int tl)
        {
            
            Console.WriteLine("Dolar kurunu giriniz.");
            int kurd = Convert.ToInt32(Console.ReadLine());
            int doltl = dolar * kurd;
            int toplamtl = doltl + tl;
            Console.WriteLine("Toplam para: " + toplamtl);
            
        }




    }
}

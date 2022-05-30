using System;

namespace KacParamVarYapısal
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
                Console.WriteLine("Dolar kurunu giriniz.");
                int kurd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kaç Euro var?");
                int euro = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Euro kurunu giriniz.");
                int kure = Convert.ToInt32(Console.ReadLine());

                int doltl = dolar * kurd;
                int eurotl = euro * kure;
                int toplamtl = doltl + eurotl + tl;
                Console.WriteLine("Toplam param: " + toplamtl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main(null);
            }
            

          





        }

        
    }
}

using System;

namespace Donusumler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert
            int x = 100;
            string y = "200";
            int toplam = x + Convert.ToInt32(y);
            Console.WriteLine("Toplam: " + toplam);

            string a = "100";
            string b = "200";
            var top1 = a + b;
            Console.WriteLine("toplam1:" + top1);

            //Cast 
            object a1    = 100;
            int    b1    = 200;
            int    top2  = (int) a1 + b1;
            Console.WriteLine("toplam2: "+ top2);

            //3.Yontem
            long   Tc = 12457845121;
            string ad = "nida";
            string soyad = "boz";
            string info = Tc.ToString() + " " + ad + " " + soyad;
            Console.WriteLine("Info:" + info);


                }
    }
}

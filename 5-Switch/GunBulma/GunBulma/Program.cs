using System;

namespace GunBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                decimal d = 0.0m;
                decimal a = 10 / d;
                
                Console.WriteLine("Bugün hangi gün: ");
                int gun = Convert.ToInt32(Console.ReadLine());
                switch (gun)
                {
                    case 1:
                        Console.WriteLine("Bugün pazartesi.");
                        break;
                    case 2:
                        Console.WriteLine("Bugün salı.");
                        break;
                    case 3:
                        Console.WriteLine("Bugün çarşamba.");
                        break;
                    case 4:
                        Console.WriteLine("Bugün perşembe.");
                        break;
                    case 5:
                        Console.WriteLine("Bugün cuma.");
                        break;
                    case 6:
                        Console.WriteLine("Bugün cumartesi.");
                        break;
                    case 7:
                        Console.WriteLine("Bugün pazar.");
                        break;
                    default:
                        Console.WriteLine("Yanlış gün girdiniz.");
                        Main(null);
                        break;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Main(null);
            }
            

        }
    }
}

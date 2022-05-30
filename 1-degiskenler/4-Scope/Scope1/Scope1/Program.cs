using System;

namespace Scope1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine("x in ilk değeri " + x);
            IkiyeKatla(x);
            Console.WriteLine("x in metod sonraki değeri " + x);
        }

        private static void IkiyeKatla(int x)
        {
            x = x * 2;
            Console.WriteLine("x in metod içi değeri " + x);

        }
    }
}

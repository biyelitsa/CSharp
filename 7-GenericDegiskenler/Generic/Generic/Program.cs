using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Diziler");
            Console.WriteLine("2- Diziler-2");
            Console.WriteLine("3- Array List");
            Console.WriteLine("4- Generic-1");
            Console.WriteLine("5- Generic-2");
            Console.WriteLine("6- Generic-3");
            Console.WriteLine("7- Generic-4");
            string secim = Console.ReadLine();
            Secim(secim);
        }



        private static void Secim(string secim)
        {
            if (secim == "1")
            {
                Dizi1();
            } 
            else if (secim == "2")
            {
                Dizi2();
            } 
            else if (secim == "3")
            {
                Alist();
            } 
            else if (secim == "4")
            {
                Generic1();
            }
            else if (secim == "5")
            {
                Generic2();
            }
            else if (secim == "6")
            {
                Generic3();
            }
            else if (secim == "7")
            {
                Generic4();
            }
            Main(null);
        }

        private static void Generic4()
        {
            List<ConsoleColor> col = new List<ConsoleColor>();
            col.Add(ConsoleColor.DarkRed);
            col.Add(ConsoleColor.DarkGreen);
            col.Add(ConsoleColor.Yellow);
            col.Add(ConsoleColor.Blue);
            col.Add(ConsoleColor.Magenta);
            foreach (var item in col)
            {
                
                Console.BackgroundColor = item;
                Console.WriteLine(item);
            } 
        }

        private static void Generic3()
        {
            List<object> esnek = new List<object>();
            esnek.Add("elma");
            esnek.Add("portakal");
            esnek.Add("kivi");
            esnek.Add(100);
            foreach (var item in esnek)
            {
                Console.WriteLine(item);
            }
        }

        private static void Generic2()
        {
            Console.WriteLine("Generic-2");
            List<string> meyveler = new List<string>();
            meyveler.Add("elma");
            meyveler.Add("portakal");
            meyveler.Add("kivi");
            foreach (var item in meyveler)
            {
                Console.WriteLine(item);
            }
        }

        private static void Generic1()
        {
            Console.WriteLine("Generic-1");
            List<int> sayilar = new List<int>();
            sayilar.Add(10);
            sayilar.Add(20);
            sayilar.Add(30);
            //sayilar.Remove(30);
            //sayilar.RemoveAt(1);
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
        }

        private static void Dizi1()
        {
            Console.WriteLine("Dizi-1");
            int[] sayilar = {10, 20, 30, 40};
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
        }
        private static void Dizi2()
        {
            string[] meyveler = {"Elma", "Armut", "Kiraz"};
            foreach (string item in meyveler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Dizi-2");
        }
        private static void Alist()
        {
            Console.WriteLine("AList-1");
            ArrayList alist = new ArrayList();
            alist.Add(10);
            alist.Add(20);
            alist.Add("Portakal");
            alist.Add("Ocak");
            //alist.Remove("Ocak");
            //alist.RemoveAt(1);
            //alist.Reverse();
            foreach (var item in alist)
            {
                Console.WriteLine(item);
            }
        }
    }

}

using System;

namespace EkArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Jagged Array
            //int[][] jaggedArr;
            //int[][] jaggedArr2 = new int[5][];
            //int[][] jaggedArr3 = new int[5][];
            //jaggedArr3[0] = new int[] { 1, 2, 3 };
            //jaggedArr3[1] = new int[] { 1, 2, 3, 4, 5, 6 };
            //jaggedArr3[2] = new int[] { 1, 2, 3, 4 };
            //jaggedArr3[3] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //jaggedArr3[4] = new int[] { 1 };

            //jaggedArr3 = JaggedArrayGoster(jaggedArr3);
            //#endregion


            //string str = "654123";
            //int strLeng = str.Length;
            //char char1 = str[0];
            //char char2 = str[1];
            //char char3 = str[2];
            //char char4 = str[3];
            //char char5 = str[4];
            //char char6 = str[5];

            //if (str.Contains('1'){

            //}


            string str2 = ".85496y,";

            // Creating array of string length 
            char[] ch = new char[str2.Length];

            // Copy character by character into array 
            for (int i = 0; i < str2.Length; i++)
            {
                ch[i] = str2[i];
            }

            char[] chars = str2.ToCharArray();
            int charsLeng = chars.Length;
            Console.WriteLine(charsLeng);

            foreach (char item in chars)
            {
                if (item == '1' || item == '2' || item == '3' || item == '4' || item == '5'
                     || item == '6' || item == '7' || item == '8' || item == '9' || item == '0' || item == ',' || item == '.')
                {
                    if (item == '0' && item == chars[0])
                    {
                        Console.WriteLine("İlk rakam 0 olamaz.");
                    } else if (item == '.' && item == chars[0])
                    {
                        Console.WriteLine("İlk değer '.' olamaz.");
                    }
                    else if (item == '.' && item == chars[5])
                    {
                        Console.WriteLine("Son değer '.' olamaz.");
                    }
                    else if (item == ',' && item == chars[0])
                    {
                        Console.WriteLine("İlk değer ',' olamaz.");
                    }
                    else if (item == '.' && item == chars[5])
                    {
                        Console.WriteLine("Son değer ',' olamaz.");
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                   
                }
                else
                {
                    Console.WriteLine("sayı giriniz!");
                }
            }












            ////int[,] ikiBoyutluArr;
            //int[,] ikiBoyutluArr2 = new int[3, 3];
            //int[,] ikiBoyutluArr3 = new int[,] { { 0, 1, 2 }, { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };

            //ikiBoyutluArr3 = IkıBoyutluArrarDoldur(ikiBoyutluArr3);
            //IkıBoyutluArrarGoster(ikiBoyutluArr3);



        //    int[] arr;
        //    arr = new int[10];
        //    arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = (i * i) + 1;
        //    }

        //    //arr = null;

        //    Random rnd = new Random();
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = rnd.Next(100);
        //    }

        //    int[] arr2;
        //    arr2 = arr;
        //    arr[0] = 100;
        //    int[] arr3 = new int[10];

        //    Array.Copy(arr, arr3, arr.Length); // Method Overload
        //    arr[0] = 1000;

        //    TekBoyutluArrarGoster(arr);
        //    Console.WriteLine("-------------");
        //    TekBoyutluArrarGoster(arr3);
        }

        static void TekBoyutluArrarGoster(int[] arr)
        {
            if (arr == null)
            {
                Console.WriteLine("Null Array. İşlem Yapamıyorum.");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                //foreach (int item in arr)
                //{
                //    Console.WriteLine(item);
                //}
            }
        }


        static int[,] IkıBoyutluArrarDoldur(int[,] arr)
        {
            if (arr == null)
            {
                Console.WriteLine("Null Array. İşlem Yapamıyorum.");
                return null;
            }
            else
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = (i + 1) * (j + 1);
                    }
                }
            }
            return arr;
        }

        static void IkıBoyutluArrarGoster(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine((i + 1) + ". satır, " + (j + 1) + ". sütun değeri: " + arr[i, j]);
                }
            }
        }

        static int[][] JaggedArrayGoster(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            return arr;
        }
    }
}
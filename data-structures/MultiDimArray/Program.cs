using System;

namespace MultiDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //JaggedArraysDemo();
            IterateOver(new[] { 1, 2, 3 });
            Console.ReadLine();
        }

        /// <summary>
        /// compiler will mark this code as unsafe and garbage collector will not move this object anywhere
        /// </summary>
        /// <param name="array"></param>
        private static unsafe void IterateOver(int[] array)
        {
            fixed (int* b = array)
            {
                int* p = b;
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(*p);
                    p++;
                }
            }
        }

        private static void MultiDimArrays()
        {
            int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < r2.GetLength(0); i++)
            {
                for (int j = 0; j < r2.GetLength(1); j++)
                {
                    Console.WriteLine($"{r2[i, j]}");
                }
                Console.WriteLine();
            }
        }

        private static void JaggedArraysDemo()
        {
            int[][] jaggedArray = new int[4][];

            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            jaggedArray[3] = new int[4];

            Console.WriteLine("Enter the numbers for a jagged array");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    string st = Console.ReadLine();

                    jaggedArray[i][j] = int.Parse(st);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Printing the elements");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]);
                    Console.Write("\0");
                }
                Console.WriteLine("");
            }
        }
    }
}

using _02_array_sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace data_structure_test
{
    [TestClass]
    public class SortingTest
    {
        private const string Value = "\n";

        [TestMethod]
        public void BubbleSort_ValidInput_SortedInput()
        {
            RunTestsForSortAlgorithm(Sorting.BubbleSort);
        }

        private void RunTestsForSortAlgorithm(Action<int[]> sort)
        {
            foreach (var sample in ArraySamples())
            {
                sort(sample);
                PrintOut(sample);
            }
        }

        private void PrintOut(int[] array)
        {
            Console.WriteLine("---------TRACE---------");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine(Value);
        }

        private int[][] ArraySamples()
        {
            int[][] sampels = new int[9][];

            sampels[0] = new[] { 1 };
            sampels[1] = new[] { 2, 1 };
            sampels[2] = new[] { 2, 1, 3 };
            sampels[3] = new[] { 1, 1, 1 };
            sampels[4] = new[] { 2, -1, 3, 3 };
            sampels[5] = new[] { 4, -5, 3, 3 };
            sampels[6] = new[] { 0, -5, 3, 3 };
            sampels[7] = new[] { 0, -5, 3, 0 };
            sampels[8] = new[] { 3, 2, 5, 5, 1, 0, 7, 8 };

            return sampels;
        }
    }
}

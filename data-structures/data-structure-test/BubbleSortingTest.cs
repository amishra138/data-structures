using _02_array_sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace data_structure_test
{
    [TestClass]
    public class BubbleSortingTest
    {

        [TestMethod]
        public void BubbleSort_ValidInput_SortedInput()
        {
            CommonMethod.RunTestsForSortAlgorithm(BubbleSorting.Sort);
        }

        [TestMethod]
        public void BubbleSort_ValidInput_Optimized_SortedInput()
        {
            CommonMethod.RunTestsForSortAlgorithm(BubbleSorting.OptimizeSort);
        }
    }
}

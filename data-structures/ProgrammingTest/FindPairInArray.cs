using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProgrammingTest
{
    public class FindPairInArray
    {
        /// <summary>
        /// Find if pair exists in an array whose sum = K
        /// </summary>
        /// <param name="arr">Array</param>
        /// <param name="k">Sum of pair</param>
        /// <returns>True if matches</returns>
        public static bool Find(int[] arr, int k)
        {
            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == k)
                    {
                        isFound = true;
                        break; //added break to improve complexity
                    }
                }

                if (isFound) //added break to improve complexity
                    break;
            }

            return isFound;
        }
    }
}

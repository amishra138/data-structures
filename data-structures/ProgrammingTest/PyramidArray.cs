namespace ProgrammingTest
{
    public class PyramidArray
    {
        static int domLength = 2;

        /// <summary>
        /// X has 6 dominoes. A dominoe is a rectangular tile with a line dividing its face into two square halves. Each half is marked with a number of spots.
        /// X wants to build a 3 stag pyramid from these dominoes. The first level should consists of three dominoes, the second level of two dominoes, and the highest of one dominoe. 
        /// The levels are arranged in such a way that the peak of the pyramid is at center: that is, each level is positioned over the center of the level below it.
        /// There is also an additional condition. The number of spots on each dominoe half should be the same as the number of spots on half positioned beneath it.
        /// Note that this doesn't apply to neighboring dominoes on the same level.
        /// Is it possbile to build a pyramid from these dominoes, as described above?
        /// Dominoes can be freely rearranged.We also assume that dominoes can be rotated(that is piece [x,y] can be treated as [x,y] or [y,x], where x denotes the number of spots in the first half-dominoes
        /// and y denotes the number of spots in the second half-dominoes).
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static string BuildPyaramid(int[] A)
        {
            int length = A.Length;
            int offset = 0;
            int currentRow = 1;
            bool result = true;

            while (result)
            {
                int currentRowLength = currentRow * domLength;

                if (offset + currentRowLength >= length)
                {
                    break;
                }

                result = CheckValuesOnRowAgainstRowBelow(A, offset, currentRowLength);
                offset += currentRowLength;
                currentRow++;
            }

            return result ? "NO" : "YES";
        }
        private static bool CheckValuesOnRowAgainstRowBelow(int[] values, int startOfCurrentRow, int currentRowLength)
        {
            int startOfNextRow = startOfCurrentRow + currentRowLength;
            int comparablePointOnNextRow = startOfNextRow + 1;
            for (int i = 0; i < currentRowLength; i++)
            {
                if (values[startOfCurrentRow + i] != values[comparablePointOnNextRow + i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

using System.Text;

namespace ProgrammingTest
{
    public class StringGenerator
    {
        /// <summary>
        /// Write a function solution that, given two integers A & B, returns a string containing exactly A letters 'a' and exactly B letters 'a' with no three consecutive letters being the same( in other words, neither "aaa" nor "bbb" may occur in the returned string).
        /// For ex - A = 5 and B = 3, function may return "aabaabab" or "abaabbaa". 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static string GenerateString(int A, int B)
        {
            StringBuilder resultString = new StringBuilder();

            while (0 < A || 0 < B)
            {
                if (A < B)
                {
                    if (0 < B--)
                    {
                        resultString.Append("b");
                    }
                    if (0 < B--)
                    {
                        resultString.Append("b");
                    }
                    if (0 < A--)
                    {
                        resultString.Append("a");
                    }
                }
                else if (A > B)
                {
                    if (0 < A--)
                    {
                        resultString.Append("a");
                    }
                    if (0 < A--)
                    {
                        resultString.Append("a");
                    }
                    if (0 < B--)
                    {
                        resultString.Append("b");
                    }
                }
                else
                {
                    if (0 < A--)
                    {
                        resultString.Append("a");
                    }
                    if (0 < B--)
                    {
                        resultString.Append("b");
                    }
                }
            }

            return resultString.ToString();
        }
    }
}

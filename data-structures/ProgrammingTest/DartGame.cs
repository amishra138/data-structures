using System;

namespace ProgrammingTest
{
    public class DartGame
    {
        /// <summary>
        /// To calculate dart score
        /// </summary>
        /// <param name="dartValues"></param>
        /// <returns></returns>
        public int CalculateScore(string[] dartValues, out string message)
        {
            int initialScore = 301;
            message = "Please start with double value, ex - D20";

            if (dartValues.Length == 0)
            {
                message = "Array can not be empty";
                return initialScore;
            }

            for (int i = 0; i < dartValues.Length; i++)
            {
                if (!dartValues[i].StartsWith('D') && initialScore == 301)
                {
                    continue;
                }

                if (dartValues[i].StartsWith('D'))
                {
                    initialScore -= CalculateScore(dartValues[i].Substring(1), 2);
                }
                else if (dartValues[i].StartsWith('T'))
                {
                    initialScore -= CalculateScore(dartValues[i].Substring(1), 3);
                }
                else
                {
                    initialScore -= CalculateScore(dartValues[i], 1);
                }
            }

            if (initialScore <= 1 && !IsValidThrow(dartValues[dartValues.Length - 1]))
            {
                message = "The player is bust";
                initialScore = 0;
            }

            return initialScore;
        }

        int CalculateScore(string value, int multiplyBy)
        {
            int score = Convert.ToInt32(value);
            return score * multiplyBy;
        }

        bool IsValidThrow(string value)
        {
            return value.Contains("D");
        }
    }
}

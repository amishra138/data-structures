using System.Text;

namespace ProgrammingTest
{
    public class StringManipulation
    {
        public void ReverseSentence(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                System.Console.WriteLine("Empty string");
            else
                System.Console.WriteLine($"Input string is : {sentence}");

            var words = sentence.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                sb.Append(words[i]);
                sb.Append(" ");
            }

            System.Console.WriteLine(sb.ToString());
        }
    }
}

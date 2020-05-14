using System.Linq;

namespace ProgrammingTest.Array
{
    public class FindNonRepeatingElementsinArray
    {
        public void Get2NonRepeatingNos(int[] arr, int firstElement, int secondElement)
        {
            var elements = arr
                            .ToList()
                            .GroupBy(x => x)
                            .Where(g => g.Count() % 2 == 1)
                            .Select(g => g.Key);

            System.Console.WriteLine("Output");
            foreach (var item in elements)
            {
                System.Console.WriteLine(item); ;
            }
        }
    }
}

using System;
using System.Diagnostics;

namespace _01_time_complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();

            var triplets = TripletSum.Count(new int[] { 1, 3, -2, 1, -3, 0, 2 });

            watch.Stop();

            Console.WriteLine($"The number of zerp-sum triplets :{triplets}");
            Console.Write($"The time taken: {watch.Elapsed:g}");
            Console.Read();
        }
    }
}

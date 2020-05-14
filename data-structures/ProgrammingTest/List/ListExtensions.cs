using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingTest.List
{
    public static class ListExtensions
    {
        public static void RunProgram()
        {
            var listOfDateString = new List<string> { "20/01/2013", "01/01/2020", "N/A", "10/01/2020", "20/01/2019" };

            Console.WriteLine($"Sort list date string, input : ");
            listOfDateString.ForEach(x => { Console.WriteLine(x); });
            Console.WriteLine($"Sort by date, output : ");
            listOfDateString.SortByDate().ForEach(x => { Console.WriteLine(x); });

            var listOfDates = new List<DateTime>
            {
                new DateTime(1980, 5, 5),
                new DateTime(1982, 10, 20),
                new DateTime(1984, 1, 4),
                new DateTime(1979, 6, 19)
            };

            Console.WriteLine($"Sort list of dates, input : ");
            listOfDates.ForEach(x => { Console.WriteLine(x); });
            Console.WriteLine($"Sort by ascending result : ");
            listOfDates.SortByDateAsc().ForEach(x => { Console.WriteLine(x); });

            Console.WriteLine($"Sort by desc result : ");
            listOfDates.SortByDateDesc().ForEach(x => { Console.WriteLine(x); });
        }

        public static List<DateTime> SortByDateAsc(this List<DateTime> listOfDates)
        {
            listOfDates.Sort((a, b) => a.CompareTo(b));

            return listOfDates;
        }

        public static List<DateTime> SortByDateDesc(this List<DateTime> listOfDates)
        {
            listOfDates.Sort((a, b) => b.CompareTo(a));

            return listOfDates;
        }

        public static List<string> SortByDate(this List<string> listOfDates)
        {
            return listOfDates.OrderByDescending(x =>
             {
                 DateTime.TryParse(x, out DateTime dt);
                 return dt;
             }).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static Random _randomGenerator = new Random();
        static Stopwatch _stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            var unsortedArray = GenerateSet(100000).ToArray();

            _stopwatch.Start();
            var sortedArray = BubbleSort.SortAscending(unsortedArray);
            _stopwatch.Stop();

            //PrintArray("unsorted", unsortedArray);
            //PrintArray("sorted", sortedArray);

            Console.WriteLine($"elapsed time: {_stopwatch.ElapsedMilliseconds/1000d} seconds");

            Console.ReadKey();
        }

        private static HashSet<int> GenerateSet(int totalRecords)
        {
            var set = new HashSet<int>();

            while(set.Count < totalRecords)
            {
                var newInt = _randomGenerator.Next(1, totalRecords * 2);

                if (set.Contains(newInt))
                    continue;

                set.Add(newInt);
            }

            return set;
        }

        private static void PrintArray(string title, int[] array)
        {
            Console.WriteLine(title + ":");

            foreach (var num in array)
            {
                var ending = num == array[array.Length - 1] ? "\n" : ", ";

                Console.Write($"{num}{ending}");
            }

            Console.WriteLine();
        }
    }
}

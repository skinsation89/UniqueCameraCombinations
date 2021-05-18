using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new string[] { "Axis P1346", "Axis P3344", "Axis P5512", "Axis Q1604", "Axis Q1605", "Axis Q6034", "Axis Q6035", "Axis Q1755",
            "Axis Q1604, Axis P1346", "Axis Q1755, Axis P5512, Axis Q1605, Axis M7001, Axis M3204", "Axis P1346, Axis P3367"  };

            var result = Combinations(data);

            foreach (var item in result)
            {
                Console.WriteLine($"[{string.Join(", ", item)}]");
            }

            Console.ReadLine();

        }






        public static IEnumerable<T[]> Combinations<T>(IEnumerable<T> source)
        {
            if (null == source)
                throw new ArgumentNullException(nameof(source));

            T[] data = source.ToArray();

            return Enumerable
              .Range(1, 1 << (data.Length) - 1)
              .Select(index => data
                 .Where((v, i) => (index & (1 << i)) != 0)
                 .ToArray());
        }

    }
}


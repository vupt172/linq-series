using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Series_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test_1();
        }
        private static void test_1()
        {
            var numbers = new List<int> { 5, 3, 7, 1, 2, 4 };
            var numbersWith10 = numbers.Append(10);
            Console.WriteLine("Numbers: " + string.Join(", ", numbers));
            Console.WriteLine("Numbers with 10: " + string.Join(", ", numbersWith10));

            //var oddNumbers = numbers.Where(number => number % 2 == 1);
            // var orderedOddNumbers = oddNumbers.OrderBy(number => number);
            var orderedOddNumbers = numbers
                .Where(number => number % 2 == 1)
                .OrderBy(number => numbers);
            Console.WriteLine("OrderedOddNumbers: " + string.Join(", ", orderedOddNumbers));
        }
    }
}

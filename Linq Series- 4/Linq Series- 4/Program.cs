using System;
using System.Linq;

namespace Linq_Series__4
{
    public class Program
    {
        static void Main(string[] args)
        {   //test_1();
            //test_2();
            test_3();
             
        }
        private static void test_1()
        {
            Console.WriteLine("Using test 1...");
            var numbers = new[] { 1, 4, 3, 99, 256, 2 };
            bool isAnyLargerThan100 = IsAnyLargerThan100_c1(numbers);
            Console.WriteLine($"Is Any > 100?: {isAnyLargerThan100}");
            bool isAnyEven = IsAnyEven_c1(numbers);
            Console.WriteLine($"Is Any Even?: {isAnyEven}");
        }
        private static void test_2()
        {
            Console.WriteLine("Using test 2...");
            var numbers = new[] { 1, 4, 3, 99, 256, 2 };
            bool isAnyLargerThan100 = IsAny(numbers, IsLargeThan100);
            Console.WriteLine($"Is Any > 100?: {isAnyLargerThan100}");
            bool isAnyEven = IsAny(numbers, IsEven);
            Console.WriteLine($"Is Any Even?: {isAnyEven}");
        }
        private static void test_3()
        {
            Console.WriteLine("Using test 3...");
            var numbers = new[] { 1, 4, 3, 99, 256, 2 };
            bool isAnyLargerThan100 = IsAny(numbers, number => number > 100);
            Console.WriteLine($"Is Any > 100?: {isAnyLargerThan100}");
            bool isAnyEven = IsAny(numbers, number => number % 2 == 0);
            Console.WriteLine($"Is Any Even?: {isAnyEven}");
        }
        //1
        private static bool IsAnyLargerThan100_c1(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (number > 100)
                {
                    return true;
                }
            }
            return false;
        }
        //2
        private static bool IsAnyEven_c1(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
        //3
        private static bool IsLargeThan100(int number)
        {
            return number > 100;
        }
        //4
        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        //5
        private static bool IsAnyLargerThan100_c2(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (IsLargeThan100(number))
                {
                    return true;
                }
            }
            return false;
        }
        //6
        private static bool IsAnyEven_c2(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (IsEven(number))
                {
                    return true;
                }
            }
            return false;
        }
        //7
        private static bool IsAny(int[] numbers, Func<int, bool> predicate)
        {
            foreach (var number in numbers)
            {
                if (predicate(number))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

using System;
using System.Linq;

namespace Linq_Series_5
{   
    public static class StringExtension
    {
        public static int GetCountOfLines(this string input)
        {
            return input.Split("\n").Length;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            //test_1()
            //test_2();
            test_3();

        }
        private static void test_1()
        {
            string str = @"My name is Vu Pham Tuan
                        I live in Ninh Binh 
                        Nice to meet you";
            int countOfLine = str.GetCountOfLines();
            Console.WriteLine("Count of line : " + countOfLine);
        }
        private static void test_2()
        {
            int[] arr = { 1, 4, 49, 98, 256, 2 };
            var evenArr = Enumerable.Where(arr, i => i % 2 == 0);
            var evenAndLargerThan50Arr = Enumerable.Where(evenArr, evenNumber => evenNumber > 50);
            foreach (int i in evenAndLargerThan50Arr) { Console.WriteLine(i); }
        }
        private static void test_3()
        {
            int[] arr = { 1, 4, 49, 98, 256, 2 };
            var evenAndLargerThan50Arr = arr.Where(number => number % 2 == 0).Where(number => number > 50);
            foreach (int i in evenAndLargerThan50Arr) { Console.WriteLine(i); }
        }
    }
}

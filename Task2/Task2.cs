using System;
using System.Linq;
namespace Task2
{
    //Let's glorify LINQ
    class Task2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 27, 5, 45, 51, 12, 7, 14, 5, 7, 47, 11, 27 };
            Console.WriteLine($"Повторювані елементи:\n{string.Join(" ", arr.Where(x => arr.Count(y => x == y) > 1).Distinct())}");
        }
    }
}

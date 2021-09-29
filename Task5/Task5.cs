using System;
using System.Linq;
namespace Task5
{
    class Task5
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 12, 27, 5, 45, 51, 12, 7, 14, 5, 7, 47, 11, 24 };
            int[] arr2 = new int[10];
            foreach (var item in arr1) Console.Write($" {item}");
            Console.WriteLine();
            arr1.Where((x) => x % 2 == 1 && Array.IndexOf(arr1, x) % 2 == 0).ToArray().CopyTo(arr2,0);
            foreach (var item in arr2) Console.Write($" {item}");
        }
    }
}

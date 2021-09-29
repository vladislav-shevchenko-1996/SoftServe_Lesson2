using System;
using System.Linq;
namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, n=20;
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int[] arr3 = new int[n];
            Random rnd = new Random();
            
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(10, 30);
                arr2[i] = rnd.Next(10, 30);
                arr3[i] = arr1[i] + arr2[i];
                sum += arr3[i];
            }
            Console.WriteLine($"arr1: {string.Join(" ", arr1)}");
            Console.WriteLine($"arr2: {string.Join(" ", arr2)}");
            Console.WriteLine($"arr3: {string.Join(" ", arr3)}");
            Console.WriteLine($"The average value of the third array elements: {sum/n}\nMax(arr3): {arr3.Max()}\nMin(arr3): {arr3.Min()}");


        }
    }
}

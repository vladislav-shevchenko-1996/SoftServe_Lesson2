using System;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100);
                Console.Write($" {arr[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0 && i%2==1)
                {
                    Console.WriteLine($"arr[{i}]\t{arr[i]}");
                    sum += arr[i];
                }
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}

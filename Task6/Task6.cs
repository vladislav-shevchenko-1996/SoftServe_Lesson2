using System;

namespace Task6
{
    class Task6
    {
        static void Main(string[] args)
        {
            int k, l, count=0, sum=0;
            Console.WriteLine("Введіть розмірність масиву:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("l=");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("k=");
            l = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100);
                Console.Write($" {arr[i]}");
            }
            Console.WriteLine();
            for (int i = 0;  i < arr.Length; i++)
            {
                if (i<k||i>l)
                {
                    sum += arr[i];
                    count++;
                    Console.WriteLine($"[{i}]\t{arr[i]}");
                }
            }
            Console.WriteLine($"Сер. знач.={sum / count}");
        }
    }
}

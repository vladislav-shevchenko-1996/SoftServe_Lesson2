using System;
namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            bool isGrowth = true;
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100);
                Console.Write($" {arr[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    if (isGrowth == true)
                    {
                        Console.Write($" {arr[i]} {arr[i + 1]}");
                        isGrowth = false;
                    }
                    else Console.Write($" {arr[i + 1]}");
                }
                else isGrowth = true;
            }
        }
    }
}

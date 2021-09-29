using System;
using System.Linq;

namespace Lesson2
{
    //Let's glorify LINQ
    class Task1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 27, 57, 45, 51, 12, 7, 14, 47 };
            Console.WriteLine(arr.Count((b) => Math.Abs(b) - Math.Abs(arr.Min()) == 5));
        }
    }
}

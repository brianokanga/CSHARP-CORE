using System;

namespace ReversingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = [9, 2, 5, 3, 7, 4, 8, 4];
            //Console.WriteLine($"{Arr}");

            //Array.Reverse(arr);
            //Console.WriteLine(String.Join(',', arr));

            int[] array = { 9, 2, 5, 3, 7, 4, 8, 4 };
            Array.Reverse(array);

            Console.WriteLine(String.Join(',', array));
        }
    }
}

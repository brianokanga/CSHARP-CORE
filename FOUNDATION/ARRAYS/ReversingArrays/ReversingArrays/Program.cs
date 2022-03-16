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

            //Array.Reverse(array);
            //Console.WriteLine(String.Join(',', array));

            var results = ReverseArray(int[]array);
            Console.WriteLine();


            //int[] arr = { 1, 2, 3, 4 };
            //var results = new int[] { };
            //for(var i = arr.Length - 1; i >= 0; i--)
            //{
            //    var results.push(arr[i]);
            //}
            //Console.WriteLine(arr1);

        }

        public static void ReverseArray(int[] a)
        {
            if (a.Length == 0) return;
            int n = a.Length - 1;
            for (int i = 0; i <= n; i++)
            {
                int temp = a[n];
                a[n--] = a[i];
                a[i] = temp;
            }
        }

    }
}

using System;
using System.IO;

namespace RandomArray
{
    public class Program
    {
        public static void PopulateArray(int[] numbers)
        {
            Random r = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(1, 101);
                Console.WriteLine($"The {i + 1}. element is {numbers[i]}");
            }
        }

        public static void CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach(int i in numbers)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of all the elements is {sum}");
        }

        public static void SaveToFile(int[] numbers, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, numbers.ToString());

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter array capacity!");
            int capacity = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[capacity];

            PopulateArray(numbers);
            Console.WriteLine();
            CalculateSum(numbers);

            string filename = @"C:\Projects\Arrays.txt";
            SaveToFile(numbers, filename,true);

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse("abc");


            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(result);
            else
                Console.WriteLine("Conversion failed");
            
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 5, 6, 7));
            Console.WriteLine(calculator.Add(1, 2, 5, 4, 5, 6));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine($"Point is at {point.Y}, {point.Y}");

                Console.WriteLine();

                point.Move(100, 200);
                Console.WriteLine($"Point is at {point.Y}, {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("An expected error occured");
            }
        }
    }
}

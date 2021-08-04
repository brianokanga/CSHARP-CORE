using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var named = (One: "0ne", Two: "two");
            Console.WriteLine($"{named.One}, {named.Two}");

            var unnamed = ("one", "two");
            Console.WriteLine($"{unnamed.Item1}, {unnamed.Item2}");
            
            //EQUATING 
            var left = (a: 5, b: 10);
            var right = (a: 5, b: 10);

            Console.WriteLine(left == right);
        }
    }
}

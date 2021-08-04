using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {


            //REFACTORED SHORT _ Null coalescing operator ??
            //Almost similar to ternary  operator

            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;  //if date has value, use on date otherwise use Date.today


            //ternary operator
            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;


            Console.WriteLine(date2);

            //LONGER VERSION
            //DateTime? date = null;
            //DateTime date2;

            //if (date != null)
            //    date2 = date.GetValueOrDefault();
            //else
            //    date2 = DateTime.Today;

            //Console.WriteLine(date2);



            //DateTime? date = new DateTime(2012, 1, 1);
            //DateTime date2 = date.GetValueOrDefault();
            //DateTime? date3 = date2;

            //Console.WriteLine(date3.GetValueOrDefault());
            //Console.WriteLine($"GetValueOrDefault {date.GetValueOrDefault()}");
            //Console.WriteLine($"HasValue : {date.HasValue}");
        }
    }
}

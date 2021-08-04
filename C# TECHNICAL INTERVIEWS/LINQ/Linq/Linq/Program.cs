using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class LinqTest
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //WITH LINQ
            var books = new BookRepository().GetBooks();

            var totalPrice = books.Sum(b=>b.Price);

            Console.WriteLine(totalPrice);

            //var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
            //var book = books.First(b => b.Title == "C# Advanced Topics");
            //var book = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            //var book = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            // var pagedBooks = books.Skip(2).Take(3);
            //var count = books.Count();  //aggregate
            //var MaxPrice = books.Max(b=>b.Price);
            //var minPrice = books.Min(b=>b.Price);
            //var totalPrice = books.Sum(b=>b.Price);

            /*
             * other important methods
             *Average(b=>b.Price);
             */
        }
    }
}

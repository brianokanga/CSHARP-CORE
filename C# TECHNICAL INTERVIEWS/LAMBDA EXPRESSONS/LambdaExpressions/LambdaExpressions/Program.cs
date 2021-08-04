using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(b => b.Price < 10);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            //wth extra method, without lambda expression 
            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            //foreach (var book in cheapBooks)
            //{
            //    Console.WriteLine(book.Title);
            //}

            //Lambda expression syntax
            // arg => expression
            //number => number * number;

            //Lambda without args
            // () => ...
            // (xyz) => ...

            //Func<int, int> square = number => number * number;
            //Console.WriteLine(square(5));

            //const int factor = 5;
            //Func<int, int> multiplier = n => n * factor;
            //var result = multiplier(10);
            //Console.WriteLine(result);
        }

        //predicate
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
 
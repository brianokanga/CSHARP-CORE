using System;

namespace Linq
{
    public class LinqQueryOperators
    {
        ////WITH LINQ
        //var book = new BookRepository().GetBooks();

        ////LINQ QUERY OPERATORS
        //var cheapBooks =
        //    from b in books
        //    where b.Price < 10
        //    orderby b.Title
        //    select b.Title;

        ////LINQ EXTENSION METHODS
        //var cheapBooks = books
        //                                .Where(b => b.Price < 10)
        //                                .OrderBy(b => b.Title)
        //                                .Select(b => b.Title);


        //    foreach (var book in cheapBooks)
        //{
        //    Console.WriteLine($"{book}");
        //    //Console.WriteLine($"{book.Title} : {book.Price} ");
        //}


        //WITHOUT LINQ
        //var books = new BookRepository().GetBooks();
        //var cheapBooks = new List<Book>();
        //foreach (var book in books)
        //{
        //    if(book.Price < 10)
        //        cheapBooks.Add(book);
        //}
        //foreach (var book in cheapBooks)
        //{
        //    Console.WriteLine($"{book.Title} : {book.Price} ");
        //}
    }
}
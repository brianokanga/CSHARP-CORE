using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is a very long post that needs to be shortened";
            var shortenedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>(){ 1,3,77,5,66,44,100};
            var max = numbers.Max();

            Console.WriteLine(shortenedPost);
            Console.WriteLine(max);
        }
    }
}
 
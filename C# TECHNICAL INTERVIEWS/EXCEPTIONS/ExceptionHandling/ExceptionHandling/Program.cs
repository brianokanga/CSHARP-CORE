using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("Eliza");
            }
            catch (Exception ex)  //global exception handler block
            {
                Console.WriteLine(ex.Message);
            }



            //try
            //{
            //    using (var streamReader = new StreamReader(@"c:\file.zip"))
            //    {
            //        var content = streamReader.ReadToEnd();
            //    }
            //}
            //catch (Exception ex)  //global exception handler block
            //{
            //    Console.WriteLine("Sorry an expected error occurred");
            //}

            //finally
            //{
            //    if(streamReader != null)
            //        streamReader.Dispose();   //close the stream reader
            //}

            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("you cannot divide by zero");
            //}
            //catch (ArithmeticException)
            //{

            //}
        }
    }
}

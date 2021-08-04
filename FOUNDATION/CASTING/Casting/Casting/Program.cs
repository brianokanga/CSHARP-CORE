using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //UP CASTING

            //Text text = new Text();
            //Shape shape = text;   //UPCASTING, implicitly, no conversion required

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width);

            //StreamReader reader = new StreamReader(new MemoryStream());
            //var list = new ArrayList();
            //list.Add(1);
            //list.Add("Eliza");
            //list.Add(new Text());

            //var anotherList = new List<Shape>();

            //DOWN CASTING

            Shape shape = new Text();  //we dont have all properties hence we have to downcast
            Text text = (Text) shape;  //DOWN CASTING Explicitly,conversion required


        }
    }
}

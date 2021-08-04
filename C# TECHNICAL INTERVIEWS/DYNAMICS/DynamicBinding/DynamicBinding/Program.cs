using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            //WITH DYNAMICS
            object obj = "Eliza";
            //obj.GetHashCode();
            dynamic excelObject = "Astar";
            excelObject.Optimize();

            //WITH REFLECTION
            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);
        }
    }
}

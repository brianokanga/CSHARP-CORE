using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates {
    class Program {
        static void Main (string[] args) {
            var processor = new PhotoProcessor ();
            var filters = new PhotoFilters ();

            //Custom Delegate instance
            //PhotoProcessor. filterHandler = filters.ApplyBrightness;

            // Inbuilt Delegate
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRefEyeFilter;

            processor.Process ("photo.jpg", filterHandler);
        }

        //extending the photo filters
        static void RemoveRefEyeFilter (Photo photo) {
            Console.WriteLine ("Apply Remove RedEye");
        }
    }
}
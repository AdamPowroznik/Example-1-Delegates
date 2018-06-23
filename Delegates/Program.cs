using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyePhotoFilter;

            processor.Process("photo.jpg", filterHandler);



            //wait
            Console.ReadKey();
        }

        static void RemoveRedEyePhotoFilter(Photo photo)
        {
            Console.WriteLine("Red eye removed");
        }
    }
}

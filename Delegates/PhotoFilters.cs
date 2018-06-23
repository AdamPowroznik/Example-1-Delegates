using System;

namespace Delegates
{

    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public void ResizePhoto(Photo photo)
        {
            Console.WriteLine("Photo resize");
        }
    }
}

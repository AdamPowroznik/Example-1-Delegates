namespace Delegates
{
    public class Photo
    {
        public void Save()
        {

        }

        public static Photo Load(string path)
        {
            return new Photo();
        }
    }
}
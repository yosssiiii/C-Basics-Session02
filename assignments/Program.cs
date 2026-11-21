using System.Drawing;
using System.Dynamic;
using System.Timers;

namespace assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            Book book1 = new Book() { title = "loyality", pages = 250 };
            object obj = book1;
            Console.WriteLine(obj);
            #endregion

        }
    }

}
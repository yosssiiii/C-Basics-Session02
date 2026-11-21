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
            //Book book1 = new Book() { title = "loyality", pages = 250 };
            //object obj = book1;
            //Console.WriteLine(obj);
            #endregion
            #region question 2
            Book book1 = new Book() { title = "loyality", pages = 250 };
            Console.WriteLine(book1.ToString());
            Console.WriteLine(book1.Equals(book1));
            Console.WriteLine(book1.GetHashCode());
            Console.WriteLine(book1.GetType());
            #endregion
        }
    }

}
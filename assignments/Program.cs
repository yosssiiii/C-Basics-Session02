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
            //Book book1 = new Book() { title = "loyality", pages = 250 };
            //Console.WriteLine(book1.ToString());
            //Console.WriteLine(book1.Equals(book1));
            //Console.WriteLine(book1.GetHashCode());
            //Console.WriteLine(book1.GetType());
            #endregion
            #region question 3
            ////int pages = "464";   (compile-time error)
            //int pages = 464;   // after fixing it
            //Console.WriteLine(pages);
            #endregion
            #region question 4
            //try{
            //    int total_grade = 10;
            //    int total_subject = 0;
            //    Console.WriteLine(total_grade / total_subject);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("can't divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion
            #region question 5
            //int page = 300;
            //double doublePage = page;
            //Console.WriteLine(doublePage);
            #endregion
            #region question 6
            //double price = 49.99;
            //int intPrice = (int)price;
            #endregion
            #region question 7
            string pagesText = "464";
            int pagesInt = Convert.ToInt32(pagesText);
            Console.WriteLine(pagesInt.GetType());
            #endregion
            //#region question8

            //#endregion

        }
    }

}
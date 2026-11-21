using System;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            Book b = new Book();
            b.Title = "Utopia";
            b.Pages = 200;

            object obj = b;
            Console.WriteLine(obj);
            #endregion

            #region Q02
            Book b2 = new Book() { Title = "Utopia", Pages = 200 };
            Console.WriteLine(b2.ToString());
            Console.WriteLine(b2.Equals(b2));
            Console.WriteLine(b2.GetHashCode());
            Console.WriteLine(b2.GetType());
            #endregion

            #region Q03
            // Compile-time error
            int pages = 464;
            Console.WriteLine(pages);
            #endregion

            #region Q04
            try
            {
                int x = 10;
                int y = 0;
                int res = x / y;
                Console.WriteLine(res);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion

            #region Q05
            int pages5 = 300;
            double d = pages5;
            Console.WriteLine(d);
            #endregion

            #region Q06
            double price = 49.99;
            int intPrice = (int)price;
            Console.WriteLine(intPrice);
            #endregion

            #region Q07
            string pagesText = "464";
            int p = Convert.ToInt32(pagesText);
            Console.WriteLine(p);
            #endregion

            #region Q08
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            string badText = "abc";
            bool result = int.TryParse(badText, out int num);
            if (result)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            #endregion

            #region Q09
            int pages9 = 464;
            string s = pages9.ToString();
            Console.WriteLine(s);
            Console.WriteLine(s.GetType());
            #endregion

            #region Q10
            int copies = 100;
            object o = copies;
            int newCopies = (int)o;

            Console.WriteLine(o);
            Console.WriteLine(newCopies);
            #endregion
        }
    }

    internal class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
    }
}
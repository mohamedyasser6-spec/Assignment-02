using System;
using System.Text;

namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            #endregion

            #region Q02
            string s1 = "Clean Code";
            string s2 = "Clean Code";
            Console.WriteLine(object.ReferenceEquals(s1, s2));
            #endregion

            #region Q03
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            Console.WriteLine(sb);
            #endregion

            #region Q04
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb);
            #endregion

            #region Q05
            string title5 = "Clean Code";
            int pages5 = 464;
            string res1 = "Book: " + title5 + ", Pages: " + pages5;
            Console.WriteLine(res1);
            #endregion

            #region Q06
            string res2 = $"Book: {title5}, Pages: {pages5}";
            Console.WriteLine(res2);
            #endregion

            #region Q07
            string res3 = string.Format("Book: {0}, Pages: {1}", title5, pages5);
            Console.WriteLine(res3);
            #endregion

            #region Q08
            int pages8 = 464;
            if (pages8 > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion

            #region Q09
            int pages9 = 464;
            bool isAvailable = true;
            if (pages9 > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion

            #region Q10
            string title10 = "Refactoring";
            switch (title10)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion

            #region Q11
            int pages11 = 464;
            string sizeLabel = pages11 > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            #endregion

            #region Q12
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            #endregion

            #region Q13
            int index = 0;
            while (index < books.Length)
            {
                Console.WriteLine(books[index]);
                index++;
            }
            #endregion

            #region Q14
            int count = 0;
            do
            {
                Console.WriteLine("Checking book...");
                count++;
            } while (count < 3);
            #endregion

            #region Q15
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            #endregion

            #region Q16
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(books[i]);
            }
            #endregion

            #region Q17
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(books[i]);
            }
            #endregion

            #region Q18
            PrintFirstBook(books);
            #endregion
        }

        static void PrintFirstBook(string[] books)
        {
            if (books.Length == 0)
            {
                return;
            }
            Console.WriteLine(books[0]);
        }
    }
}
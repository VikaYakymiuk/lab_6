using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var Authorsurname = line1[0];
            var Authorname = line1[1];
            var bookname = Console.ReadLine();
            var bookprice = double.Parse(Console.ReadLine());
            try
            {
                var book = new Book(bookname, Authorname, Authorsurname, bookprice);
                var goldenbook = new GoldenEditionBook(bookname, Authorname, Authorsurname, bookprice);
                Console.WriteLine(book.ToString());
                Console.WriteLine(goldenbook.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

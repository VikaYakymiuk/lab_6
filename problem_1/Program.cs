using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Ill", 30);
            var child = new Child("Pet", 16);
            Console.WriteLine(person.ToString());
            Console.WriteLine(child.ToString());
        }
    }
}

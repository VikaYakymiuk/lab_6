using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstinput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var studentfirstname = firstinput[0];
            var studentlastname = firstinput[1];
            var facultynumber = firstinput[2];

            var secondinput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var workerfirstname = secondinput[0];
            var workerlastname = secondinput[1];
            var workersalary = double.Parse(secondinput[2]);
            var workerhours = double.Parse(secondinput[3]);
            try
            {
                var student = new Student(studentfirstname, studentlastname, facultynumber);
                var worker = new Worker(workerfirstname, workerlastname, workersalary, workerhours);
                Console.WriteLine(student.ToString()); Console.WriteLine(worker.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    public class Student : Human
    {
        private string facultynumber;
        public Student(string firstname, string lastname, string facultynumber) : base(firstname, lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.FacultyNumber = facultynumber;
        }
        public string FacultyNumber
        {
            get { return this.facultynumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10 || !value.ToCharArray().All(x => char.IsDigit(x) || char.IsLetter(x)))
                {
                    throw new ArgumentException("Invalid faculty number");
                }
                this.facultynumber = value;
            }
        }
        public override string ToString()
        {
            var line = new StringBuilder();
            line.AppendLine($"First Name : {this.FirstName}");
            line.AppendLine($"Last Name : {this.LastName}");
            line.AppendLine($"Faculty number : {this.FacultyNumber}");
            return line.ToString();
        }
    }
}

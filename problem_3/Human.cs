using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    public class Human
    {
        private string firstname;
        private string lastname;

        public Human(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.firstname = lastname;
        }
        public string FirstName
        {
            get { return this.firstname; }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {this.firstname}");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: {this.firstname}");
                }
                this.firstname = value;
            }
        }
        public string LastName
        {
            get { return this.lastname; }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {this.lastname}");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException($"Expected length at least 3 symbols! Argument: {this.lastname}");
                }
                this.lastname = value;
            }
        }
    }
}

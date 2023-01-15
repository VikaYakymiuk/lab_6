using lab6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6

{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
            this.Age = age;
        }
        public int Age
        {
            get { return base.Age; }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException(String.Format(" Child's age must be less than 15!"));
                }
                base.Age = value;
            }
        }
    }
}

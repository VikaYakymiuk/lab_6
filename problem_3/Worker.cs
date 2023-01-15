using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    internal class Worker : Human
    {
        private double weeksalary;
        private double hperday;
        public Worker(string firstname, string lastname, double weeksalary, double hperday) : base(firstname, lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.weeksalary = weeksalary;
            this.hperday = hperday;
        }

        public double Weeksalary
        {
            get { return this.weeksalary; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {this.weeksalary}");
                }
                this.weeksalary = value;
            }
        }
        public double Hperday
        {
            get { return this.hperday; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {hperday}");
                }
                this.hperday = value;
            }
        }
        private double SalaryPerHour()
        {
            return this.weeksalary / (hperday * 5.0);
        }
        public override string ToString()
        {
            var line = new StringBuilder();
            line.AppendLine($"First Name : {this.FirstName}");
            line.AppendLine($"Last Name : {this.LastName}");
            line.AppendLine($"Week Salary : {string.Format("{0:0.00}", this.Weeksalary)}");
            line.AppendLine($"Hours per day : {string.Format("{0:0.00}", this.Hperday)}");
            line.AppendLine($"Salary per hour : {string.Format("{0:0.00}", this.SalaryPerHour())}");
            return line.ToString();
        }
    }
}

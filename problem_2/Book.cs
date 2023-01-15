using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2
{
    public class Book
    {
        private string authorsurname;
        private string authorname;
        private string name;
        private double price;

        public Book(  string authorsurname, string authorname, string name, double price)
        {
            this.AuthorSurName = authorsurname;
            this.AuthorName = authorname;
            this.Name = name;
            this.Price = price;
        }
        public string AuthorSurName
        {
            get { return this.authorsurname; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || char.IsDigit(value[0]))
                {
                    throw new ArgumentException("Author not valid");
                }
                this.authorsurname = value;
            }
        }

        public string AuthorName
        {
            get { return this.authorname; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid author name");
                }
                this.authorname = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid");
                }
                this.name = value;
            }
        }
        public virtual double Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Name}")
            .AppendLine($"Author: {this.AuthorName}" + " " + this.AuthorSurName)
            .AppendLine($"Price: {string.Format("{0:0.00}", this.Price)}");
            return resultBuilder.ToString();
        }

    }
}

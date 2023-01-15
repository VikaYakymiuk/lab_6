using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook( string authorsurname, string authorname, string name, double price) : base( authorsurname, authorname, name, price)
        {
        }
        public override double Price
        {
            get { return base.Price * 1.3; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidIt.Shared
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Condition { get; set; }
        public int PageCount {  get; set; }
        public double StartingPrice { get; set; }
        public User User { get; set; }
       
    }
}

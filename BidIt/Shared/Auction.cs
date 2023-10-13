using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidIt.Shared
{
    public class Auction
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StartingTime { get; set; } 
        public DateTime EndingTime { get; set; }
        public Company Company { get; set; }

       
    }
}

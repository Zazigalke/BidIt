using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidIt.Shared
{
    public class Offer
    {
     
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public Book Book { get; set; }
        public Auction Auction { get; set; }

    }
}

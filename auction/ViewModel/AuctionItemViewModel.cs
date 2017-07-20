using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using auction.Models;

namespace auction.ViewModel
{
    public class AuctionItemViewModel
    {
        public Person Bidder { get; set; }
        public List<AuctionItem> AucationItems{ get; set; }
        //test
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace auction.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuctionItemView
    {
        public string AuctionItemTypeName { get; set; }
        public string AuctionDescription { get; set; }
        public string AuctionName { get; set; }
        public bool AuctionActive { get; set; }
        public Nullable<int> BidPersonId { get; set; }
        public Nullable<decimal> BidAmount { get; set; }
        public string BidderName { get; set; }
        public string BidderMobilePhone { get; set; }
        public int AuctionItemId { get; set; }
        public int ItemTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AuctionId { get; set; }
        public bool Auctioned { get; set; }
        public Nullable<int> BidId { get; set; }
    }
}

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
    
    public partial class AuctionItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AuctionItem()
        {
            this.Bids = new HashSet<Bid>();
        }
    
        public int AuctionItemId { get; set; }
        public int ItemTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AuctionId { get; set; }
        public bool Auctioned { get; set; }
        public Nullable<int> BidId { get; set; }
    
        public virtual Auction Auction { get; set; }
        public virtual AuctionItemType AuctionItemType { get; set; }
        public virtual Bid Bid { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bid> Bids { get; set; }
    }
}

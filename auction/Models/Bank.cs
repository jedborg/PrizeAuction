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
    using System.ComponentModel.DataAnnotations;
    public partial class Bank
    {
        public int BankId { get; set; }

        [Display(Name = "Person")]
        public int PersonId { get; set; }

        [Display(Name = "Auction")]
        public int AuctionId { get; set; }

        public decimal Bank1 { get; set; }
    
        public virtual Auction Auction { get; set; }
        public virtual Person Person { get; set; }
    }
}

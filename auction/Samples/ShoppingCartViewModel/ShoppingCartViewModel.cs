using System.Collections.Generic;

namespace auction.Models 
{
    public class ShoppingCartViewModel 
	{
        public IEnumerable<Product> Products { get; set; }
        public decimal CartTotal { get; set; }
        public string Message { get; set; }
    }
}